package main
import b64 "encoding/base64"

func main() {
  data := "base64 encoded string"
  sEnc := b64.StdEncoding.EncodeToString([]byte(data))
  fmt.Println(sEnc)
}
