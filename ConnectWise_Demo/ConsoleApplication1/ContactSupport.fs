﻿module ContactSupport
open canopy
open runner
open OpenQA.Selenium
open System.IO

//ConnectWise URL
let ConnectWiseLink = "https://www.connectwise.com/"

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
let fileUploaderBtn = "#fileUploader"
let Submit = "input[type='submit']"

//start test execution
let sendTicket _ = 
    once (fun _ -> url ConnectWiseLink)

    //access the website and navigate to Support page
    url ConnectWiseLink
    click ResourcesTab
    click GetSupport

    //enter ticket information
    FirstName << "Mikhail"
    LastName << "Rybalchenko"
    Company << "Test Company"
    EmailAddress << "test@test.com"
    BusinessPhone << "555-555-5555"
    //click Product
    //press Keys.ArrowDown
    //press Keys.ArrowDown
    //press Keys.Enter
    click Product
    click "option[value='LabTech']"

    Summary << "This is a Test"
    IssueDetails << "No issues"
    
    //upload image to fileuploader
    let fileToUpload = FileInfo(Path.Combine("C:\Users\mrybalchenko\Desktop","test-img.png"))
    fileUploaderBtn << fileToUpload.FullName
