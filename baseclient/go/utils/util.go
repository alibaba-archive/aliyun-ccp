package utils

import (
	"time"
)

func GetRFC2616Date() string {
	gmt := time.FixedZone("GMT", 0)
	return time.Now().In(gmt).Format("Mon, 02 Jan 2006 15:04:05 GMT")
}
