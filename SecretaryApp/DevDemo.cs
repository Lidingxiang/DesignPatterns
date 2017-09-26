using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SecretaryApp
{
    public class DevDemo
    {
        public string ClearText(byte[] finalPlainTextArray)
        {
            // 使用utf-8编码（也可以使用其它的编码）
            Encoding sEncoding = Encoding.GetEncoding("utf-8");
            var plainTextString = sEncoding.GetString(finalPlainTextArray);
            return plainTextString;
        }

        public static byte[] DecryptTextFromMemory(byte[] EncryptedDataArray, byte[] Key, byte[] IV)
        {
            // 建立一个MemoryStream，这里面存放加密后的数据流 
            MemoryStream msDecrypt = new MemoryStream(EncryptedDataArray);

            // 使用MemoryStream 和key、IV新建一个CryptoStream 对象 
            CryptoStream csDecrypt = new CryptoStream(msDecrypt, new TripleDESCryptoServiceProvider().CreateDecryptor(Key, IV), CryptoStreamMode.Read);

            // 根据密文byte[]的长度（可能比加密前的明文长），新建一个存放解密后明文的byte[]
            byte[] DecryptDataArray = new byte[EncryptedDataArray.Length];

            // 把解密后的数据读入到DecryptDataArray
            csDecrypt.Read(DecryptDataArray, 0, DecryptDataArray.Length);

            msDecrypt.Close();
            csDecrypt.Close();

            return DecryptDataArray;
        }
    }
}
