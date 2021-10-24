/*************Example based on Python*************************

// Say you have two classes with compatible interfaces:
// RoundHole and RoundPeg.
class RoundHole is
    constructor RoundHole(radius) { ... }

    method getRadius() is
        // Return the radius of the hole.

    method fits(peg: RoundPeg) is
        return this.getRadius() >= peg.getRadius()

class RoundPeg is
    constructor RoundPeg(radius) { ... }

    method getRadius() is
        // Return the radius of the peg.


// But there's an incompatible class: SquarePeg.
class SquarePeg is
    constructor SquarePeg(width) { ... }

    method getWidth() is
        // Return the square peg width.


// An adapter class lets you fit square pegs into round holes.
// It extends the RoundPeg class to let the adapter objects act
// as round pegs.
class SquarePegAdapter extends RoundPeg is
    // In reality, the adapter contains an instance of the
    // SquarePeg class.
    private field peg: SquarePeg

    constructor SquarePegAdapter(peg: SquarePeg) is
        this.peg = peg

    method getRadius() is
        // The adapter pretends that it's a round peg with a
        // radius that could fit the square peg that the adapter
        // actually wraps.
        return peg.getWidth() * Math.sqrt(2) / 2


// Somewhere in client code.
hole = new RoundHole(5)
rpeg = new RoundPeg(5)
hole.fits(rpeg) // true

small_sqpeg = new SquarePeg(5)
large_sqpeg = new SquarePeg(10)
hole.fits(small_sqpeg) // this won't compile (incompatible types)

small_sqpeg_adapter = new SquarePegAdapter(small_sqpeg)
large_sqpeg_adapter = new SquarePegAdapter(large_sqpeg)
hole.fits(small_sqpeg_adapter) // true
hole.fits(large_sqpeg_adapter) // false

*************Example based on Python*******************/
using System;
namespace RefactoryGuru.DesignPattern.Adapter.SquarePegAndRoundHoles
{
    public class RoundHole
    {
        public double radius { get; set; }
        public bool fits(IRoundPeg roundPeg)
        {
            return radius >= roundPeg.radius;
        }
    }

    public interface IRoundPeg
    {
        double radius { get; set; }
    }
    public class RoundPeg : IRoundPeg
    {
        public double radius { get; set; }
    }

    // But there's an incompatible class: SquarePeg.
    public class SquarePeg
    {
        public double width { get; set; }
        public SquarePeg() : this(0) { }// unecessary
        public SquarePeg(double width)
        {
            this.width = width;
        }
    }

    public class SquarePegAdapter : IRoundPeg
    {
        private readonly SquarePeg peg;
        public double radius
        {
            get
            {
                return peg.width * Math.Sqrt(2) / 2;
            }
            set
            {
                radius = peg.width * Math.Sqrt(2) / 2;
            }
        }
        public SquarePegAdapter(SquarePeg peg)
        {
            this.peg = peg;
        }
        
    }



    public class SquarePegAndRoundHoles
    {
        public static void Program()
        {
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("--->Start of the SquarePegAndRoundHoles Program");
            //Example 1
            RoundPeg roundPegA = new RoundPeg();
            roundPegA.radius = 1.3;
            Console.WriteLine($"I have a roundPegA whose the radius is {roundPegA.radius}");

            RoundHole roundHole = new RoundHole();
            roundHole.radius = 0.3;
            Console.WriteLine($"I have a roundHole whose the radius is {roundHole.radius}");

            var result = roundHole.fits(roundPegA) ? "Fit" : "Not Fit";
            Console.WriteLine($"They are {result}");

            //Example 2
            RoundHole hole = new RoundHole();
            hole.radius = 5;
            SquarePeg smallSqPeg = new SquarePeg(5);
            SquarePeg largeSqPeg = new SquarePeg(10);
            // roundHole.fits(smallSqPeg); this wont compile (incompatible types)

            SquarePegAdapter smallSquarePegAdapter = new SquarePegAdapter(smallSqPeg);
            SquarePegAdapter largeSquarePegAdapter = new SquarePegAdapter(largeSqPeg);
            Console.WriteLine(hole.fits(smallSquarePegAdapter)); // true
            Console.WriteLine(hole.fits(largeSquarePegAdapter)); // false
            


            Console.WriteLine("--->End of the SquarePegAndRoundHoles Program");

        }
    }
}
