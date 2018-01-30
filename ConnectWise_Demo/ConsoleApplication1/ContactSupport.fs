module ContactSupport
open canopy
open runner
open OpenQA.Selenium

//ConnectWise URL
let ConnectWise = "https://www.connectwise.com/"

//selectors
let ResourcesTab = "li[data-node='86625e09-631a-4e54-8a53-560b8e98269a']"
let GetSupport = "//p[contains(text(), 'Get support now')]"
let FirstName = "#field0"
let LastName = "#field1"
let Company = "#field2"
let EmailAddress = "#field3"
let BusinessPhone = "#field4"
let Product = "#field5"
let Summary = "#field6"
let IssueDetails = "#field7"
let fileUploader = "#fileUploader"
let Submit = "input[type='submit']"

let sendTicket _ = 
    once (fun _ -> url ConnectWise)

    url ConnectWise
    click ResourcesTab
    click GetSupport
    FirstName << "Mikhail"
    LastName << "Rybalchenko"
    Company << "Test Company"
    EmailAddress << "test@test.com"
    BusinessPhone << "555-555-5555"
    Product << "ConnectWise Automate"
    Summary << "This is Test"
    IssueDetails << "No issues"
    fileUploader << "‪C:\Users\mryba\Pictures\test.jpg"