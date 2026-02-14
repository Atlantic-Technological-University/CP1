/// Filename: Enigma.java
// / Author: Dr. Shane Wilson
/// Description: Add a useful description of this file

import java.util.Arrays;
import java.util.List;

public final class Enigma {

    public static String Encrypt(String message, int incrementNumber,List<String> rotors ){
        // TODO - Implement the Encrypt method
        // Steps in brief
        // 1. Apply the CAESAR shift using the increment number

        String alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        char CAESARShift [] = new char[26];

        char decodedWord [] = {};
        decodedWord = message.toUpperCase().toCharArray();

        char encryptedCode [] = new char[26];
        CAESARShift = alphabet.toCharArray();

        for (int i = 0; i < decodedWord.length; i++) {
            int CAESERShiftInLetters = 0;

            // Check if the character is spaceBar or not, if yes, skip CAESARShift 
            String decodedWordIsSpaceBar = new StringBuilder().append(decodedWord[i]).toString();
            for (int j = 0; j < encryptedCode.length; j++) {
                if (decodedWordIsSpaceBar.contains(" ")) {
                    break;
                }

                // If character is NOT spaceBar, then do CAESARShift
                if (decodedWord[i] == CAESARShift[j]) {
                    CAESERShiftInLetters = j+incrementNumber+i;
                    System.out.println(j);
                    break;
                }
            }
            



            if(CAESERShiftInLetters > 26){
                CAESERShiftInLetters -= 26;
            }
            
            if (!decodedWordIsSpaceBar.contains(" ")) {
                decodedWord[i] = CAESARShift[CAESERShiftInLetters];
            }
        }


        // Part 2 rotors shift

        // char decodedWord [] = new char [200];
        // char encryptedCode [] = new char[26];

        // decodedWord = message.toCharArray();

        // for (int i = 0; i < rotors.size()-1; i++) {
        //     for (int j = 0; j < decodedWord.length; j++) {
        //         encryptedCode = rotors.get(i).toCharArray();

        //         int shiftInLetters = j+incrementNumber;

        //         if(shiftInLetters > 26){
        //             shiftInLetters -= 26;
        //         }

        //         decodedWord[j] = encryptedCode[shiftInLetters];

        //     }            
        // }

        String encryptedWord = "";

        for (char c : decodedWord) {
            encryptedWord += c;
        }

        return encryptedWord;

        // 2. For each rotor in the list rotors
        //  2.1 Translate the message using the rotor
        // 3. Return the encrypted string

        // return "Implement the encrypt method";
    }


    public static String Decrypt(String message, int incrementNumber, List<String> rotors)
    {
        // TODO - Implement the Decrypt method

        // Steps in brief
        // 1. For each rotor in the list rotors, starting with the last rotor
        //  1.1 Translate the message using the rotor
        // 2. Apply the CAESAR shift
        // 3. Return the decrypted string

        return "Implement the decrypt";

    }
}
