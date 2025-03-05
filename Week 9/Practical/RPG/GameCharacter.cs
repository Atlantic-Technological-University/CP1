// Written by Dr. Shane Wilson.
// The author licenses this file to you under the MIT license.
// See the LICENSE file in the solution root for more information.

/*
* Filename: GameCharacter.cs 
*
* Version information v0.1
* Author: Dr. Shane Wilson
* Date: 05/03/2021
* Description: Acts as the base class for game character RPG classes
* Copyright notice
*/

using System;

namespace RPG
{

    /// <summary> Class <c> GameCharacter </c> implements the base class for a 
    ///  simple RGP game character
    /// </summary>

    // TODO - Create an enumeration for game character state. 
    
    public class GameCharacter
    {
        //Class fields (data members)
        private static int s_numberOfCharacters = 0; //s_ for static field

        private string _characterName; //Cannot be empty
        private int _health; //Must be in range [0..100].
        private double _weightLimit; //Must be > 0
        private double _totalWeightOfItems; //Cannot exceed weightLimit
        private int _food; //Must be >=0

        // Class properties
        public string CharacterName
        {
            get { return _characterName; }
            set
            {
                if (value.Length < 1)
                {
                    throw new ArgumentException(
                        $"{nameof(value)} must be at least one character long");
                }

                _characterName = value;
            }
        }

        public int Health
        {
            //get { return health_; }
            get => _health;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException(
                        $"{nameof(value)} Health cannot be negative");
                }

                _health = value;
            }
        }

        public double WeightLimit
        {
            get { return _weightLimit; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException(
                        $"{nameof(value)} weight limit cannot be negative");
                }

                _weightLimit = value;
            }
        }

        //Added to the spec, needs to be read only
        public double TotalWeightOfItems
        {
            get { return _totalWeightOfItems; }
        }

        public CharacterState CharState
        {
            get => characterState;
            set
            {
                characterState = value;
            }
        }

    }
}
