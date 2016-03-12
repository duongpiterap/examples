Dim base64Decoded as String = "base64 encoded string"
Dim base64Encoded As String
Dim data As Byte()
data = System.Text.ASCIIEncoding.ASCII.GetBytes(base64Decoded)
base64Encoded = System.Convert.ToBase64String(data)
Console.WriteLine(base64Encoded)
