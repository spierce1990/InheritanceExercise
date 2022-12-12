using Inheritance;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
// TODO Be sure to follow best practice when creating your classes

// Create a class Animal DONE
// give this class 4 members that all Animals have in common DONE


// Create a class Bird DONE
// give this class 4 members that are specific to Bird DONE
// Set this class to inherit from your Animal Class DONE

// Create a class Reptile DONE
// give this class 4 members that are specific to Reptile DONE
// Set this class to inherit from your Animal Class DONE




/*Create an object of your Bird class
 *  give values to your members using the object of your Bird class
 *  
 * Creatively display the class member values 
 */

Bird Parrot = new Bird();
Parrot.Inches = 10;
Parrot.Age = 2;
Parrot.HasLongLegs = false;
Parrot.IsFriendly = true;
Parrot.Name = "Parrot";

//display method

Parrot.Display();



/*Create an object of your Reptile class
 *  give values to your members using the object of your Reptile class
 *  
 * Creatively display the class member values 
 */
Reptile Lizard = new Reptile();
Lizard.Size = "small";
Lizard.Climb = true;
Lizard.Swim = true;

Console.WriteLine($"The Lizard is {Lizard.Size} and it can swim {Lizard.Swim}");
