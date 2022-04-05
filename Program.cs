// Программа решающая задачу. Массив решил задать изначально, чтобы не раздувать код и keep it simple соблюсти. :)

string [] initArr = new string [] {"string1","Hi","and","thank","you", "for","fine","st","ud","y"};

int c = 0;
for (int i = 0; i < initArr.Length; i++)
    { if (initArr[i].Length<=3)
        c++;
    }

string [] newArr = new string [c];
int k = 0;
for (int j = 0; j < initArr.Length; j++)
    { if (initArr[j].Length<=3)
        {
            newArr[k] = initArr[j];
            Console.Write($"{newArr[k]}, ");
            k++;
        }
    }
