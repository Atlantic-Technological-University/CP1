/// Filename: Enigma.java
// / Author: Dr. Shane Wilson
/// Description: Add a useful description of this file

import java.util.ArrayList;
import java.util.List;

public final class Enigma {

    public static String shiftCAESAR(String message, int incrementNumber){
        String alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        char [] decodedWord = message.toUpperCase().toCharArray();
        char [] shiftCAESAR = alphabet.toCharArray();

        for (int i = 0; i < decodedWord.length; i++) {
            int shiftInLettersCAESAR = 0;

            // Check if the character is spaceBar or not, if yes, skip shiftCAESAR 
            String decodedWordIsSpaceBar = new StringBuilder().append(decodedWord[i]).toString();
            for (int j = 0; j < shiftCAESAR.length; j++) {
                // If character is NOT spaceBar, then do shiftCAESAR
                if (decodedWord[i] == shiftCAESAR[j] && !decodedWordIsSpaceBar.contains(" ")) {
                    shiftInLettersCAESAR = j+incrementNumber+i;
                    break;
                }
            }
            

            if(shiftInLettersCAESAR > 26){
                shiftInLettersCAESAR -= 26;
            }
            
            if (!decodedWordIsSpaceBar.contains(" ")) {
                decodedWord[i] = shiftCAESAR[shiftInLettersCAESAR];
            }
        }

        StringBuilder bld = new StringBuilder();
        for (char c : decodedWord) {
            bld.append(c);
        }

        return bld.toString();
    }


    public static String rotorsShift(String message, List<String> rotors){
        // For test purpose array below
        char [] wordWithAppliedCAESAR = message.toUpperCase().toCharArray();
        
        // Actual rotor array used to encode
        ArrayList<Character> rotor = new ArrayList<>();

        // Alphabet array
        String alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        char [] alphabetArray = alphabet.toCharArray();
        ArrayList<Character> alphabetCharacters = new ArrayList<>();

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
            for(int j = 0; j < wordWithAppliedCAESAR.length; j++){
                if(wordWithAppliedCAESAR[j] != ' '){
                    int shift = alphabetCharacters.indexOf(wordWithAppliedCAESAR[j]);
                    wordWithAppliedCAESAR[j] = rotor.get(shift);
                }
            }

            // Clear previous rotor after being used
            rotor.clear();
        }

        // Assemble encoded word
        StringBuilder bld = new StringBuilder();
        for (char  c : wordWithAppliedCAESAR) {
            bld.append(c);
        }
        

        return bld.toString();
    }


    public static String Encrypt(String message, int incrementNumber,List<String> rotors ){
        // TODO - Implement the Encrypt method
        // Steps in brief

        // 1. Apply the CAESAR shift using the increment number
        // Method shiftCAESAR was created

        // 2. For each rotor in the list rotors
        //  2.1 Translate the message using the rotor
        // 3. Return the encrypted string
        // Method rotorsShift was created - in case it was not done

        return rotorsShift(shiftCAESAR(message, incrementNumber), rotors);
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
