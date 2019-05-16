﻿using System;

namespace Task10
{
    enum Status
    {
        Eat = 0,
        Sleep = 1,
        Move = 2
    }
    interface IAnimal
    {
        string Name { get; set; }
        int Age { get; set; }
        string Sex { get; set; }
        Status CurrentOccupation { get; set; }

    }
}
