package utils

import (
	"encoding/json"
	"time"
)

func Prettify(i interface{}) string {
	resp, _ := json.MarshalIndent(i, "", "   ")
	return string(resp)
}
func GetRFC2616Date() string {
	gmt := time.FixedZone("GMT", 0)
	return time.Now().In(gmt).Format("Mon, 02 Jan 2006 15:04:05 GMT")
}
