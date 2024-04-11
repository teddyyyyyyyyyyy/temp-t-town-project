const url = "http://localhost:5075/api/Admins"
let myAdmins = []
let app = document.getElementById("app")

async function HandleOnLoad(){
    let response = await fetch(url, {
        headers: {
            "Content-Type": "application/json"
        }
    })
    let data = await response.json()
    myAdmins = data
    console.log(myAdmins)
    await renderAdmins()
}

