string base64Decoded = "base64 encoded string";
string base64Encoded;
byte[] data = System.Text.ASCIIEncoding.ASCII.GetBytes(base64Decoded);
base64Encoded = System.Convert.ToBase64String(data);
Console.WriteLine(base64Encoded)
