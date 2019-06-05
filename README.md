# OpenBankingApiTester
App for testing PSD2 API with QWAC (TPP) and QSEAL certificates. Now supports only POST methods.

![alt text](https://github.com/miroslavm87/OpenBankingApiTester/blob/master/images/OpenBankingApiTester.png)

#### Supports:
1. Medicinos Bankas - https://developers.medbank.lt
2. Šiaulių Bankas - https://openbanking.siauliubankas.lt
3. Baltic International Bank - https://openbanking.bib.eu

#### PFX generation with OpenSSL
    openssl pkcs12 -export -out tpp.pfx -inkey tpp_private.key -in tpp.crt
    openssl pkcs12 -export -out qseal.pfx -inkey qseal_private.key -in qseal.crt -CSP "Microsoft Enhanced RSA and AES Cryptographic Provider"

FYI: This program is not officially supported by these banks. PSD2 API is in developing stage and authorization methods can change any day.
