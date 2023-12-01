// C++ Intro.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <vector>



int Factorial(int number)
{
    if (number > 1)
    {
        return number* Factorial(number - 1);
    }
    else
    {
        return 1;
    }
}
char Grade(int Grade)
{
    int rnum = Grade;
    char letter = NULL;
    if (rnum <= 69)
    {
        letter = 'F';
    }
    if (rnum <= 72 && rnum >= 70)
    {
        letter = 'D';
    }
    if (rnum <= 79 && rnum >= 73)
    {
        letter = 'C';
    }
    if (rnum <= 89 && rnum >= 80)
    {
        letter = 'B';
    }
    if (rnum <= 100 && rnum >= 90)
    {
        letter = 'A';
    }
    if (rnum < 0 || rnum > 100)
    {
        letter = '?';
    }
    return letter;
}

int main()
{
    #pragma region 5-1

    std::cout << "\t  Why!?\n";
    std::cout << "\t  Why,\n" << "\tBatman Why!?\n";

    #pragma endregion

    #pragma region 5-2

    float Farray[] = { 1.23f, 55.678f, 21.21f, 4.11f, 9.0076, };
    int farraySize = sizeof(Farray) / sizeof(Farray[0]);
    char Tbat[] = { 'B','a','t','m','a','n','!','!','!','\0' };
    int carraySize = sizeof(Tbat) / sizeof(Tbat[0]);

    for (int i = 0; i < farraySize; i++)
    {
        std::cout << Farray[i] << "\n";
    }

    for (int i = 0; i < carraySize; i++)
    {
        std::cout << Tbat[i];
    }

#pragma endregion

    #pragma region 5-3
    for (int i = 0; i <= 100; i += 2)
    {
        std::cout << "\n" << i;
    }
    int counter = 0;
    while (counter <= 100)
    {
        std::cout << "\n" << counter;
        counter++;
    };
    counter = 0;
    do
    {
        std::cout << "\n" << counter;
        counter++;
    } while (counter <= 100);



#pragma endregion

    #pragma region 5-4
    srand(time(NULL));
    for (size_t i = 0; i < 10; i++)
    {
        int rnum = rand() % 101;
        char letter = Grade(rnum);      
        std::cout <<"\n"<< rnum << " " << letter;
    }
    

    #pragma endregion

    #pragma region 5-5
    srand(time(NULL));
    
    

    for (size_t i = 0; i < 10; i++)
    {

        int Choice = rand() % 6;

        switch (Choice)
        {

        case 0:
            std::cout << "\nThe Bat";
            break;
        case 1:
            std::cout << "\nBatman";
            break;
        case 2:
            std::cout << "\nBats";
            break;
        case 3:
            std::cout << "\nThe Dark Night";
            break;
        case 4:
            std::cout << "\nNightwing";
            break;
        case 5:
            std::cout << "\nBruce";
            break;


        default:
            break;
        }

    }

    #pragma endregion

    #pragma region 5-6
    srand(time(NULL));   
    enum SuperPowers
    {
        Fire = 0,

        Water = 1,

        Air = 2,

        Earth = 3,

        Avatar = 4,

        
      
    };
    enum Comp
    {
        Fail = -1,

        Inconclusive = 0,

        Pass = 1
    };
    SuperPowers Power = static_cast<SuperPowers>(rand() % Avatar);
    switch (Power)
    {
    case Fire:
        std::cout << "\nYour a Firebender";
        break;
    case Water:
        std::cout << "\nYour a Waterbender";
        break;
    case Air:
        std::cout << "\nYour a Airbender";
        break;
    case Earth:
        std::cout << "\nYour a Earthbender";
        break;
    case Avatar:
        std::cout << "\nYou are the Avatar";
        break;
    default:

        break;
    }
    Comp test = static_cast<Comp>(strcmp("Batman","Aquaman"));
    switch (test)
    {
    case Fail:
        std::cout <<"\n"<< "Barman is !< Aquaman";
        break;
    case Inconclusive:
        std::cout << "\n" << "Barman is !<= Aquaman";
        break;
    case Pass:
        std::cout << "\n" << "Barman is always > Aquaman";
        break;
    default:
        break;
    }
    
    

    #pragma endregion

    #pragma region 5-7
    for (size_t i = 1; i <= 15 ; i++)
    {        
        std::cout << "\n" << Factorial(i);
    }


    #pragma endregion

    #pragma region 5-8
    srand(time(NULL));
    std::vector<char> letterGrades;
    int num[10] = {};
    for (size_t i = 0; i < 10; i++)
    {
        num[i] = rand() % 101;
        letterGrades.push_back(Grade(num[i]));
    }
    for (size_t i = 0; i < letterGrades.size(); i++)
    {
        std::cout << "\n" << num[i] << letterGrades[i];
    }
        
 

    #pragma endregion
}


// Run program: Ctrl + F5 or Debug > Start Without Debugging menu
// Debug program: F5 or Debug > Start Debugging menu

// Tips for Getting Started: 
//   1. Use the Solution Explorer window to add/manage files
//   2. Use the Team Explorer window to connect to source control
//   3. Use the Output window to see build output and other messages
//   4. Use the Error List window to view errors
//   5. Go to Project > Add New Item to create new code files, or Project > Add Existing Item to add existing code files to the project
//   6. In the future, to open this project again, go to File > Open > Project and select the .sln file
