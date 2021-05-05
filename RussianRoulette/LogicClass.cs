using System;
using System.Runtime.InteropServices.ComTypes;
using System.Windows.Forms;

namespace RussianRoulette
{
    class LogicClass
    {
        //this is the bullet
        int Bullet;
        int ShootingChances = 4; // chances to shoot on head
        int ShootingAwayChances = 2; //chances to shoot away

        // this function loads the gun
        public void Load()
        {
            Bullet = 6;
        }

        // this function spin the bullets
        public int Spin()
        {
            Random rand = new Random();
            Bullet = rand.Next(1, 7); //setting a range
            MessageBox.Show((Bullet).ToString());
            return Bullet;
        }

        // this function shooting at head
        public void ShootAtHead()
        {
            {
                if (Bullet == 1)
                {
                    //tell the user you died!
                    MessageBox.Show("You lost your life, you scored 0 points do you want to play again?", "Game Over");
                    Application.Restart();
                }
                else
                {
                    ShootingChances--;
                    Bullet--;
                    //if chances are zero tell him you are dead else tell him keep playing
                    if (ShootingChances == 0)
                    {
                        MessageBox.Show("You lost your life, you scored 0 points do you want to play again?", "Game Over");
                        Application.Restart();
                    }
                    else
                    {
                        MessageBox.Show("All the best!! You are still alive");
                    }
                }
                
            }
        }
            // this function shoot away from head
            public void ShootAway()
            {
                if (Bullet == 1 && ShootingAwayChances == 2)
                {
                    // the user is dead!
                    MessageBox.Show("Wow ! You win the game and you scored 100 points ");
                    Application.Restart();
                }
                else if (Bullet == 1 && ShootingAwayChances == 1)
                {
                    // the user is dead!
                    MessageBox.Show("Wow ! You win the game and you scored 50 points ");
                    Application.Restart();
                }
                else
                {
                    ShootingAwayChances--;
                    Bullet--;
                    if(ShootingAwayChances==0)
                    {
                        MessageBox.Show("You lost your all lives, you scored 0 points do you want to play again?", "Game Over");
                        Application.Restart();
                    }
                    else
                    {
                        MessageBox.Show("Try your luck.. ");
                    }
                    
                }
            }
            

            }
        } 
     



        









