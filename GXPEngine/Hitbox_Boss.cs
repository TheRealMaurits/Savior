﻿using System;
using GXPEngine;

namespace GXPEngine
{
    class Hitbox_Boss : Sprite
    {
        public Hitbox_Boss() : base("hitbox_boss.png")
        {
            visible = false;

            Spawn();
        }

        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //                                                                                                                        Spawn()
        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        void Spawn()
        {
            SetOrigin(width / 2, height / 2);
            SetXY(-300, 413);
        }

        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //                                                                                                                        OnCollision()
        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        public void OnCollision(GameObject other)
        {
            if (other is Hitbox_Fist && Globals.bossIsAttacking == false && Globals.bossIsDead == false)
            {
                Globals.health_boss = Globals.health_boss - 1;
            }
        }

        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //                                                                                                                        Update()
        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        void Update()
        {

        }
    }
}
