open canopy
open runner
open System

chromeDir <- "C:\Webdriver"
start Chrome
pin FullScreen

ContactSupport.sendTicket()

run()

printfn "press [enter] to exit"
System.Console.ReadKey() |> ignore

quit()