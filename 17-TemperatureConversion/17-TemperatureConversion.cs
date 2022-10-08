using System;

namespace ProgrammingExercisesIST
{
    class Project_17_TemperatureConversion
    {
        static void Main(string[] args)
        {
            /* TASK:
             * Implement a program that can convert from Fahrenheit to Celcius
             * and from Celcius to Fahrenheit. The user chooses which to do.
             * This program must make use of what we have learnt about functions.
             * Look back at the "DistanceConversion" program if you get stuck.
             */



        }

        static void Pseudocode()
        {
            // Below is the pseudocode for this task to guide you
            // You may choose to implement this in a different way if you wish
            /* 
                BEGIN Main
                    choice = MainMenu()
                    IF choice = 1 THEN
                        result = CelciusToFahrenheit()
                        PRINT result
                    ELSE IF choice = 2 THEN
                        result = FahrenheitToCelcius()
                        PRINT result
                    ELSE
                        PRINT "Invalid Choice!"
                    END IF
                END Main
                

                BEGIN CelciusToFahrenheit
                    c = GetTemperature("Celcius")
                    f = (c * 9/5) + 32
                    RETURN f
                END CelciusToFahrenheit 


                BEGIN FahrenheitToCelcius
                    f = GetTemperature("Celcius")
                    c = (f − 32) x 5/9
                    RETURN c
                END FahrenheitToCelcius
                

                BEGIN GetTemperature(unit)
                    PRINT "Enter temperature in " unit
                    INPUT temp
                    RETURN temp
                END GetTemperature
             */

        }
    }
}
