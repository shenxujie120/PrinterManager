using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Web;
using System.IO;
using System.Reflection;

namespace PrinterManager.SDK
{
    /// <summary>
    /// 加密与解密方法
    /// </summary>
    public class Encrypt
    {
        private const string DES3_KEY = "514345744E41596C4E41496C";

        //DES3加密
        private static byte[] iv =  { 1, 2, 3, 4, 5, 6, 7, 8 };//des 向量  
        public static byte[] EncyptString(string data)
        {
            byte[] byt = System.Text.Encoding.UTF8.GetBytes(data);
            TripleDESCryptoServiceProvider tdsp = new TripleDESCryptoServiceProvider();
            tdsp.Mode = CipherMode.ECB;             //设置加密模式ECB
            tdsp.Padding = PaddingMode.PKCS7;
            Type t = Type.GetType("System.Security.Cryptography.CryptoAPITransformMode");
            object obj = t.GetField("Encrypt", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.DeclaredOnly).GetValue(t);

            MethodInfo mi = tdsp.GetType().GetMethod("_NewEncryptor", BindingFlags.Instance | BindingFlags.NonPublic);
            ICryptoTransform desCrypt = (ICryptoTransform)mi.Invoke(tdsp, new object[] { System.Text.Encoding.UTF8.GetBytes(DES3_KEY), CipherMode.ECB, null, 0, obj });

            MemoryStream mStream = new MemoryStream();
            CryptoStream cStream = new CryptoStream(mStream,
                desCrypt, CryptoStreamMode.Write);//ECB模式可以忽略IV向量
            cStream.Write(byt, 0, byt.Length);
            cStream.FlushFinalBlock();
            cStream.Close();
            return mStream.ToArray();
        }

        public static byte[] toHex(byte[] digestByte)
        {
            byte[] rtChar = new byte[digestByte.Length * 2];
            for (int i = 0; i < digestByte.Length; i++)
            {
                byte b1 = (byte)(digestByte[i] >> 4 & 0xF);
                byte b2 = (byte)(digestByte[i] & 0xF);
                rtChar[(i * 2)] = ((byte)(b1 < 10 ? b1 + 48 : b1 + 55));
                rtChar[(i * 2 + 1)] = ((byte)(b2 < 10 ? b2 + 48 : b2 + 55));
            }
            return rtChar;
        }

        ////MD5加密
        public static string getMd5Hash(string input)
        {
            // Create a new instance of the MD5CryptoServiceProvider object.
            MD5CryptoServiceProvider md5Hasher = new MD5CryptoServiceProvider();

            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hasher.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("X2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }

        //DES3解密
        public static string DES3Decrypt(string strString)
        {
            TripleDESCryptoServiceProvider DES = new TripleDESCryptoServiceProvider();
            MD5CryptoServiceProvider hashMD5 = new MD5CryptoServiceProvider();
            string strKey = DES3_KEY;
            DES.Key = hashMD5.ComputeHash(Encoding.Default.GetBytes(strKey));
            DES.Mode = CipherMode.ECB;
            ICryptoTransform DESDecrypt = DES.CreateDecryptor();
            string result = "";
            try
            {
                byte[] Buffer = Convert.FromBase64String(strString);
                result = Encoding.Default.GetString(DESDecrypt.TransformFinalBlock(Buffer, 0, Buffer.Length));
            }
            catch (System.Exception e)
            {
                throw (new System.Exception("null", e));
            }
            return result;
        }

    }
}
