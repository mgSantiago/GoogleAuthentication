function handleCredentialResponse(response) {
  console.log("Encoded JWT ID token: " + response.credential);
}

window.onload = function () {
  google.accounts.id.initialize({
    client_id: "120594299479-2vpvivc02b53pdqchmijle5l59j6750s.apps.googleusercontent.com",
    callback: handleCredentialResponse
  });
  google.accounts.id.renderButton(
    document.getElementById("buttonDiv"),
    { theme: "outline", size: "large" }  // customization attributes
  );
  google.accounts.id.prompt(); // also display the One Tap dialog
}
