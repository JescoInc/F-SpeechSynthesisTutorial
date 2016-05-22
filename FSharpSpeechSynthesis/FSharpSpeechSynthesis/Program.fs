open System
open System.Speech.Synthesis

// reads the user's input
let userInput() = Console.ReadLine()


let voice = 
    // Speech Synthesizer initialization with the F# version of the using statement from C#
    use speech = new SpeechSynthesizer()
    // 
    try
    // Implicitly setting the voice to be the simplified Chinese voice made by Microsoft
    speech.SelectVoice("Microsoft Huihui Desktop")
    // seting the speech to derive from the user's imput
    speech.Speak(userInput())
    with
    // A little bit of exception handling
    | :? System.ArgumentException as ex -> ()
    | ex -> printf "%s" ex.Message
    

// entry point for the program which will actually call the functions made above.
let speechSynth = voice
    
    