using System;

namespace Collision
{
    /*
     * Create two classes one called GameObject and another called Ghost. GameObject needs to have properties for X and Y velocities and the 
     * following method:
       Public virtual void Collision(GameObject HitObj){…}

       For those students that would like to look up formulas for realistic collisions go for it. For everyone else as long as velocities change 
       after collisions, it works for this assignment.

        The Ghost class should be a GameObject that only changes velocity if it collides with another Ghost.
     */
    class HW2Program
    {
        static void Main(string[] args)
        {
            GameObject mario = new GameObject(5, 3, new int[2,2]);
            GameObject luigi = new GameObject(5, 9, new int[4, 5]);

            Ghost casper = new Ghost(7, 3, new int[1, 3]);
            Ghost nick = new Ghost(14, 21, new int[3, 9]);

            mario._location = new int[3, 3];
            luigi._location = new int[3, 3];

            mario.Collision(luigi);



        }
    }

    
    public class GameObject
    {
        
        public virtual string _type { get; set; } //to be able to differentiate between types of objects
        public int _xVelocity { get; set; }
        public int _yVelocity { get; set; }

        public int[ , ] _location { get; set; }

        public GameObject(int xSpeed, int ySpeed, int[ , ] location) //automatically sets the velocity and location of the object
        {
            _xVelocity = xSpeed;
            _yVelocity = ySpeed;
            _location = location;
        }

        public virtual void Collision(GameObject HitObj) //when objects collide and both of them are not ghosts, then velocity will go down to zero
        {
            if (this._location == this._location && HitObj._type != "ghost")
            {
                this._xVelocity = 0;
                this._yVelocity = 0;
                HitObj._xVelocity = 0;
                HitObj._yVelocity = 0;
            }
        }
    }

    public class Ghost : GameObject
    {
        

        public Ghost(int xSpeed, int ySpeed, int[,] location) : base(xSpeed, ySpeed, location) //constructor for ghost using parameters for base class
        {
            _type = "ghost";

        }
        public override void Collision(GameObject HitObj) //both objects have to be ghosts for velocity to be effected
        {
            if (HitObj._type == "ghost")
            {
                this._xVelocity = 0;
                this._yVelocity = 0;
                HitObj._xVelocity = 0;
                HitObj._yVelocity = 0;
            }
        }
    }
}
