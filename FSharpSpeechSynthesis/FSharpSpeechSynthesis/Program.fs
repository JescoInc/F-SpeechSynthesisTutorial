open System
open System.Speech.Synthesis

let voice (sentence : string) = 
    // Speech Synthesizer initialization with the F# version of the using statement from C#
    use speech = new SpeechSynthesizer()
    // Implicitly setting the voice to be the simplified Chinese voice made by Microsoft
    speech.SelectVoice("Microsoft Huihui Desktop")
    // seting the speech to derive from the user's imput
    speech.Speak(sentence)

// entry point for the program which will actually call the voice function and read what the user Inputs
let speak = voice(Console.ReadLine())
    
    