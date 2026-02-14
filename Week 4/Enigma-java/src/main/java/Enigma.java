/// Filename: Enigma.java
// / Author: Dr. Shane Wilson
/// Description: Add a useful description of this file

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

public final class Enigma {

    public static String CAESARshift(String message, int incrementNumber){
        String alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        char CAESARShift [] = new char[26];

        char decodedWord [] = {};
        decodedWord = message.toUpperCase().toCharArray();

        CAESARShift = alphabet.toCharArray();

        for (int i = 0; i < decodedWord.length; i++) {
            int CAESERShiftInLetters = 0;

            // Check if the character is spaceBar or not, if yes, skip CAESARShift 
            String decodedWordIsSpaceBar = new StringBuilder().append(decodedWord[i]).toString();
            for (int j = 0; j < CAESARShift.length; j++) {
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

        String encryptedWord = "";

        for (char c : decodedWord) {
            encryptedWord += c;
        }

        return encryptedWord;
    }

    public static String Encrypt(String message, int incrementNumber,List<String> rotors ){
        // TODO - Implement the Encrypt method
        // Steps in brief
        // 1. Apply the CAESAR shift using the increment number
        CAESARshift(message, incrementNumber);


        // Part 2 rotors shift



        // for (int i = 0; i < rotors.size(); i++) {
        //     for (int j = 0; j < decodedWord.length; j++) {
        //         // encryptedCode = rotors.get(i).toCharArray();
        //         // ArrayList<Character> encryptedCode = new ArrayList<Character>();
        //         ArrayList<Character> sample = new ArrayList<Character>();
                
        //         for(char c : rotors.get(i).toCharArray()){
        //             sample.add(c);
        //         }

        //         char current = decodedWord[j];

        //         System.out.print(sample.indexOf(current) + " ," + sample.size());

        //         int shiftInLetters = j+incrementNumber;

        //         if(shiftInLetters > 26){
        //             shiftInLetters -= 26;
        //         }

        //         decodedWord[j] = encryptedCode[shiftInLetters];

        //         sample.clear();
        //         System.out.println(sample);
        //     }            
        // }

        // String encryptedWord = "";

        // for (char c : decodedWord) {
        //     encryptedWord += c;
        // }

        // return encryptedWord;

        // 2. For each rotor in the list rotors
        //  2.1 Translate the message using the rotor
        // 3. Return the encrypted string

        return "Implement the encrypt method";
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
