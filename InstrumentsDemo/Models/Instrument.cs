/*
 * Musical Instruments
 * Provide a form where the user can enter a new instrument
 * Validate that the year is less than or equal to the current year
 * Validate that the price is greater than 0
 * Type will be a dropdown:  Piano, Electric Guitar, Synth, Trumpet
 * Color will be a dropdown: Black, White, Red, Green, Blue, Yellow
 * If the validation comes back wrong, go back to form with an error message
 * Otherwise go to a "thank you" page showing the instrument that was entered

Type: string (e.g. Piano, Guitar, etc.)
Model: string
Color: string
Year: int
Price: decimal
 * 
 */


namespace InstrumentsDemo.Models
{
    public class Instrument
    {
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }
    }
}
