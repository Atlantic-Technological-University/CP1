/// Filename: Enigma.java
// / Author: Dr. Shane Wilson
/// Description: Add a useful description of this file

import java.util.ArrayList;
import java.util.List;

public final class Enigma {

    private static final String ALPHABET = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    
    private Enigma()
    {

    }

    public static String encrypt(String message, int incrementNumber,List<String> rotors ){
        return rotorsShift(shiftCAESAR(message, incrementNumber), rotors);
    }

    public static String shiftCAESAR(String message, int incrementNumber){

        char [] decodedWord = message.toUpperCase().toCharArray();
        char [] shiftCAESAR = ALPHABET.toCharArray();

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
        char [] alphabetArray = ALPHABET.toCharArray();
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

    public static String decrypt(String message, int incrementNumber, List<String> rotors)
    {
        StringBuilder m = new StringBuilder(message.toUpperCase());

        // reverse rotors
        for (int i=rotors.size()-1; i>=0; i--)    // for each rotor, starting with the last one
        {
            for (int j=0; j<m.length(); j++) // for each character in the message
            {
                char currentChar = m.charAt(j);
                if (ALPHABET.indexOf(currentChar) != -1) // if the character is in the alphabet
                {
                    int position=rotors.get(i).indexOf(currentChar);
                    char translatedCharacter = ALPHABET.charAt(position);
                    m.setCharAt(j, translatedCharacter);
                }
            }
        }

        // reverse caesar shift
        for (int i=0; i<m.length(); i++)
        {
            char currentChar = m.charAt(i);
            if (ALPHABET.indexOf(currentChar) != -1)
            {
                int position = ALPHABET.indexOf(currentChar);
                int shiftedPosition=position-incrementNumber-i;

                // wrap back to start of alphabet
                if (shiftedPosition<0)
                    shiftedPosition+=26;
                
                char replacementChar = ALPHABET.charAt(shiftedPosition);
                m.setCharAt(i, replacementChar);
            }
        }

        return m.toString();

    }
}
