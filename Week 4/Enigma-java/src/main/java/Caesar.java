public class Caesar{

public static void main(String[] args)
{
      Caesar caesar = new Caesar();
      System.out.print(caesar.ceasarShift("can80k", 7)); //test
}
   
   public String ceasarShift(String message, int shift)
    {
        String alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        StringBuilder newString = new StringBuilder();
        
        for(int i = 0; i < message.length(); i++) //looping through the message
        {
         char currentChar = message.toUpperCase().charAt(i); //getting the char at a given index
         int alphaIndex = alphabet.indexOf(currentChar);  //getting the position of that char in the alphabet 

         if(alphaIndex == -1)
         {
            newString.append(currentChar); //if char is not in alphabet just add it to final string without shifting
         }
         else 
         {
         alphaIndex = (alphaIndex + shift) % 25; //if shift > 25 making it out of bounds, it loops around the alphabet
         if(alphaIndex<0)
         {
            alphaIndex += 25; //accounts for alphaIndex being negative, loops it back around
         } 
         char newChar = alphabet.charAt(alphaIndex); //new char after shifting
         newString.append(newChar);
      }
         shift++;
         
         }
         return newString.toString();
}
}
