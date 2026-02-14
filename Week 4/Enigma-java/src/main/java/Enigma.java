/// Filename: Enigma.java
// / Author: Dr. Shane Wilson
/// Description: Add a useful description of this file

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

public final class Enigma {

    public static String CAESARshift(String message, int incrementNumber){
        String alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        // char CAESARShift [] = new char[26];
        // char decodedWord [] = {};

        char [] decodedWord = message.toUpperCase().toCharArray();
        char [] CAESARShift = alphabet.toCharArray();

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
                    // System.out.println(j);
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


    public static String RotorsShift(String message, int incrementNumber, List<String> rotors){
        // For test purpose array below
        // char [] CAESARAppliedWord = {'H', 'E', 'L', 'L', 'O', ' ', 'W', 'O', 'R', 'L', 'D'};
        char [] CAESARAppliedWord = message.toUpperCase().toCharArray();
        
        // Actual rotor array used to encode
        ArrayList<Character> rotor = new ArrayList<Character>();

        // Alphabet array
        String alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        char [] alphabetArray = alphabet.toCharArray();
        ArrayList<Character> alphabetCharacters = new ArrayList<Character>();

        for (Character c : alphabetArray) {
            alphabetCharacters.add(c);
        }


        for(int i = 0; i < rotors.size(); i++){
            // Buffer array to extract characters
            char [] rotorLetters = rotors.get(i).toCharArray();

            // Fill the rotor array
            for(int z = 0; z < rotorLetters.length; z++){
                rotor.add(z, rotorLetters[z]);
            }

            // Apply rotors encoding
            for(int j = 0; j < CAESARAppliedWord.length; j++){
                // System.out.println(alphabetCharacters);
                if(CAESARAppliedWord[j] == ' '){
                    continue;
                }
                else {
                    int shift = alphabetCharacters.indexOf(CAESARAppliedWord[j]);
                    // System.out.print(rotor.get(shift) + ", ");
                    CAESARAppliedWord[j] = rotor.get(shift);
                }
            }

            // Clear previous rotor after being used
            rotor.clear();
        }

        // Assemble encoded word
        String encodedWord = "";
        for (char  c : CAESARAppliedWord) {
            encodedWord += c;
        }
        

        return encodedWord;
    }


    public static String Encrypt(String message, int incrementNumber,List<String> rotors ){
        // TODO - Implement the Encrypt method
        // Steps in brief

        // 1. Apply the CAESAR shift using the increment number
        // Method CAESARshift was created

        // 2. For each rotor in the list rotors
        //  2.1 Translate the message using the rotor
        // 3. Return the encrypted string
        // Method RotorsShift was created - in case it was not done

        return RotorsShift(CAESARshift(message, incrementNumber), incrementNumber, rotors);
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
