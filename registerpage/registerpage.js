
function handleOnLoad(){
    //getCustomer()
}

function getCustomer(){

    let usernameInput = document.getElementById('username').value;
    let passwordInput = document.getElementById('password').value;
    let firstNameInput = document.getElementById('firstname').value;
    let lastNameInput = document.getElementById('lastname').value;
    let emailInput = document.getElementById('email').value;
    let phoneNumberInput = document.getElementById('phoneNumber').value;
    let customerAddressInput = document.getElementById('customerAddress').value;
    let customerData = {
        userName: usernameInput,
        password: passwordInput,
        firstName: firstNameInput,
        lastName: lastNameInput,
        email: emailInput,
        phoneNumber: phoneNumberInput,
        customerAddress: customerAddressInput
    }
    const url = "http://localhost:5075/api/customers"

    fetch(url, {
        method: "POST",
        body: JSON.stringify(customerData),
        headers: {
            "Content-Type": "application/json"
        }
    })
}