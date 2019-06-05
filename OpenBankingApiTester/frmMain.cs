using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;

namespace OpenBankingApiTester
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void CmdSelectQWAC_Click(object sender, EventArgs e)
        {
            DialogResult result = ofdPFX.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtQWACDir.Text = ofdPFX.FileName;
            }
        }

        private void CmdSelectQSEAL_Click(object sender, EventArgs e)
        {
            DialogResult result = ofdPFX.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtQSEALDir.Text = ofdPFX.FileName;
            }
        }

        private void CmdSendRequest_Click(object sender, EventArgs e)
        {
            try
            {
                SaveSetttings();

                txtResponse.Text = "";
                X509Certificate2 TPPCertificate = new X509Certificate2(txtQWACDir.Text);

                var clientHandler = new HttpClientHandler();
                // Attach to request the TPP certificate
                clientHandler.ClientCertificates.Add(TPPCertificate);
                HttpClient client = new HttpClient(clientHandler);

                // Data for test request
                HttpContent requestBody = new StringContent(txtRequestBody.Text, Encoding.UTF8, "application/json");
                byte[] requestBodyBytes = requestBody.ReadAsByteArrayAsync().Result;

                #region Digest
                SHA256 sha256Hash = SHA256.Create();
                var digestHashBytes = sha256Hash.ComputeHash(requestBodyBytes);
                string calculatedDigest = "";
                foreach (byte theByte in digestHashBytes)
                {
                    calculatedDigest += theByte.ToString("x2");
                }
                #endregion

                #region Signature
                X509Certificate2 QSEALCertificateWithPrivateKey = new X509Certificate2(txtQSEALDir.Text, "", X509KeyStorageFlags.Exportable);
                //Get only certificate without keys
                X509Certificate2 QSEALCertificate = new X509Certificate2(QSEALCertificateWithPrivateKey.Export(X509ContentType.Cert));
                RSACryptoServiceProvider QSEALPrivate = (RSACryptoServiceProvider)QSEALCertificateWithPrivateKey.PrivateKey;

                var signatureBytes = QSEALPrivate.SignData(requestBodyBytes, HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1);
                string keyId = "SN = " + TPPCertificate.SerialNumber + ", CA = " + TPPCertificate.Issuer;
                string signature = System.Convert.ToBase64String(signatureBytes);
                #endregion

                #region Request ID
                Random random = new Random();
                int RequestId = random.Next();
                #endregion

                client.DefaultRequestHeaders.Add("X-Request-ID", RequestId.ToString());
                client.DefaultRequestHeaders.Add("Digest", "SHA256=" + calculatedDigest);
                client.DefaultRequestHeaders.Add("Signature", "keyId='" + keyId + "', signature = '" + signature + "'");
                client.DefaultRequestHeaders.Add("TPP-Signature-Certificate", System.Convert.ToBase64String(QSEALCertificate.RawData));

                var response = client.PostAsync(txtURL.Text, requestBody).Result;
                response.EnsureSuccessStatusCode();
                string responseContent = response.Content.ReadAsStringAsync().Result;
                txtResponse.Text = prettyJson(responseContent);
            }
            catch (Exception ex)
            {

                txtResponse.Text += Environment.NewLine + ex.ToString();
            }
        }

        private void SaveSetttings()
        {
            Properties.Settings.Default.QWACFile = txtQWACDir.Text;
            Properties.Settings.Default.QSEALFile = txtQSEALDir.Text;
            Properties.Settings.Default.RequestUrl = txtURL.Text;
            Properties.Settings.Default.RequstBody = txtRequestBody.Text;
            Properties.Settings.Default.Save();
        }

        private void LoadSettings()
        {
            txtQWACDir.Text = Properties.Settings.Default.QWACFile;
            txtQSEALDir.Text = Properties.Settings.Default.QSEALFile;
            txtURL.Text = Properties.Settings.Default.RequestUrl;
            txtRequestBody.Text = Properties.Settings.Default.RequstBody;
        }

        private string prettyJson(string uglyJson)
        {
            try
            {
                dynamic parsedJson = JsonConvert.DeserializeObject(uglyJson);
                return JsonConvert.SerializeObject(parsedJson, Formatting.Indented);
            }
            catch
            {
                return uglyJson;
            }

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            LoadSettings();
        }
    }
}
