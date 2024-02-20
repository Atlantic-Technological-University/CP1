public class myDecryption 
{

   // main method
   public static void main(String[] args) 
   {
      // create an instance of the myDecryption class
      myDecryption decryptCaesar = new myDecryption();
   
      // Call the decryptString
      System.out.println(decryptCaesar.decryptString("EGIK", 4));
   }

   // method to decrypt string using caesar cipher
   public String decryptString(String msg, int shift) 
   {
      // Create an array
      // int myArray = ["EKMFLGDQVZNTOWYHXUSPAIBRCJ"];
      // Realised working with letters in a normal String format is more
      // straightforward than using an array
      // find the index of each letter
      // check if character is indeed a letter and if not print an error message
      // take note of count?
      // reverse the caesar shift
      // decrement
      // shift--;
   
      // NB!! All string characters must be in uppercase
      
      // Define the alphabet
      String alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
      // String.charAt(0);
   
      // Build a stringbuilder to store the decrypted message
      StringBuilder decryptedMsg = new StringBuilder();
   
      // for loop to iterate through the characters in the message
      for (int i = 0; i < msg.length(); i++) 
      {
         // Get the current character in iteration and convert it to all caps
         char currentChar = Character.toUpperCase(msg.charAt(i));
      
         // Check if the character is a letter
         if (Character.isLetter(currentChar)) //if it is a char, shift and append
         {
            // Find the index of the current character in the alphabet
            // index needs to be 0-25
            int alphaIndex = alphabet.indexOf(currentChar);
         
            // Reverse the Caesar shift method to decrypt
            // Plus 26 
            alphaIndex = (alphaIndex - shift + 26) % 26;
         
            // Store the decrypted character in a variable called decryptedChar
            char decryptedChar = alphabet.charAt(alphaIndex);
         
            // If the character is not a letter, append it unchanged
            decryptedMsg.append(decryptedChar);
         }
         
         // need to account for non-characters in the string. They will be appended to the final string without being shifted
         else 
         {
            decryptedMsg.append(currentChar);         //if it's not a char, just append without shifting
         }
         
         // Decrement the shift for the next character
         shift++;
      }
    // Return the decrypted message as a string
      return decryptedMsg.toString();
   }
}