using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SecretaryApp
{
    public class EnvDemo
    {

        public byte[] PlainTextArray()
        {
            // 待加密的字符串
            string plainTextString = "Here is some data to encrypt. 这里是一些要加密的数据。";

            // 使用utf-8编码（也可以使用其它的编码）
            Encoding sEncoding = Encoding.GetEncoding("utf-8");

            // 把字符串明文转换成utf-8编码的字节流
            byte[] plainTextArray = sEncoding.GetBytes(plainTextString);

            return plainTextArray;
        }


        public Tuple<byte[], byte[]> GetKeyAndIv()
        {
            var tDeSalg = new TripleDESCryptoServiceProvider();

            byte[] keyArray = tDeSalg.Key;

            byte[] ivArray = tDeSalg.IV;

            return Tuple.Create(keyArray, ivArray);
        }

        public static byte[] EncryptString(byte[] plainTextArray, byte[] key, byte[] iv)
        {
            // 建立一个MemoryStream，这里面存放加密后的数据流
            var mStream = new MemoryStream();

            // 使用MemoryStream 和key、IV新建一个CryptoStream 对象
            CryptoStream cStream = new CryptoStream(mStream, new TripleDESCryptoServiceProvider().CreateEncryptor(key, iv), CryptoStreamMode.Write);

            // 将加密后的字节流写入到MemoryStream
            cStream.Write(plainTextArray, 0, plainTextArray.Length);

            //把缓冲区中的最后状态更新到MemoryStream，并清除cStream的缓存区 
            cStream.FlushFinalBlock();

            // 把解密后的数据流转成字节流 
            byte[] ret = mStream.ToArray();

            // 关闭两个streams. 
            cStream.Close();
            mStream.Close();

            return ret;
        }
    }
}
