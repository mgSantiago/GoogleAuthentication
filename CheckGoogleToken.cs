using Google.Apis.Auth;

bool valid;
var token = "";

GoogleJsonWebSignature.Payload payload = await GoogleJsonWebSignature.ValidateAsync(token);
if (!payload.Audience.Equals("120594299479-2vpvivc02b53pdqchmijle5l59j6750s.apps.googleusercontent.com"))
    valid = false;
if (!payload.Issuer.Equals("accounts.google.com") && !payload.Issuer.Equals("https://accounts.google.com"))
    valid = false;
if (payload.ExpirationTimeSeconds == null)
    valid = false;
else
{
    DateTime now = DateTime.Now.ToUniversalTime();
    DateTime expiration = DateTimeOffset.FromUnixTimeSeconds((long)payload.ExpirationTimeSeconds).DateTime;
    if (now > expiration)
    {
        valid = false;
    }
}
