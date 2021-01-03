#include <stdio.h>
#include <stdlib.h>
    /*
double cube(double num);


int max(int num1, int num2, int num3)
{
    int result;
    if(num1 >= num2 && num1 >= num3) {
        result = num1;
    } else if(num2 >= num1 && num2 >= num3){
        result = num2;
    } else {
        result = num3;
    }
    return result;
}

struct Student{
    char name[50];
    char major[50];
    int age;

    double gpa;
};
    */

int main()
{
    /*
    char line[255];
    FILE * fpointer = fopen("employees.txt","r");

    fgets(line, 255, fpointer);
    fgets(line, 255, fpointer);
    printf("%s", line);
    //FILE * fpointer = fopen("employees.txt","a");

    //fprintf(fpointer, "\nKelly, Customer Service");
    //fprintf(fpointer, "Jim, Salesman\nPam, Receptionist\nOscar, Accounting");

    fclose(fpointer);
    /*
    r ... read;
    w ... write;
    a ... append;
    */


    /*
    int age = 30;
    int * pAge = &age;

    printf("%d",*pAge);



    int age = 30;
    int * pAge = &age;
    double gpa = 3.4;
    double *pGpa = &Gpa;
    char grade = 'A';
    char * aGrade = &grade;

    printf("age: %p\ngpa: %p\ngrade: %p\n", &age, &gpa, &grade);


    int nums[3][2] = {
                    {1,2},
                    {3,4},
                    {5,6}
                    };
    int i,j;
    for(i = 0; i < 3; i++){
        for(j=0; j<2; j++){
            printf("%d,", nums[i][j]);
        }
        printf("\n");
    }



    int i;
    int luckyNumbers[] = {4, 7, 2, 12, 23, 42, 34, 53, 22};
    for(i = 1; i < 9; i++){
        printf("%d\n", luckyNumbers[i]);
    }

    int i = 1;
    while (i <= 5){
        printf("%d\n", i);
        i++;
    }

    }


     }

    /*
    int secretNumber = 5;
    int guess;
    int guessCount = 0;
    int guessLimit = 3;
    int outOfGuesses = 0;

    while(guess != secretNumber && outOfGuesses == 0){
        if(guessCount < guessLimit){
            printf("Enter a number: ");
            scanf("%d", &guess);
            guessCount++;
        } else{
            outOfGuesses = 1;
        }
    }
    if(outOfGuesses == 1){
        printf("You Lost");
    } else {
        printf("You WIn");
    }
    /*
    int i = 6;
    do{
        printf("%d\n", i);
        i++;

    }while (i <= 5);


    struct Student student1;
    student1.age = 22;
    student1.gpa = 3.2;
    strcpy( student1.name, "Lukas Macha");
    strcpy( student1.major, "Engineering");

    printf("%s", student1.name);

    char grade = 'C';

    switch(grade){
    case 'A' :
        printf("You did great!");
        break;
    case 'B':
        printf("You did alright!");
        break;
    case 'C':
        printf("You passed alright");
        break;
    case 'D':
        printf("You did very bad!");
        break;
    case 'F' :
        printf("You failed!");
        break;
    default :
        printf("Invalid grade");
    }


    double num1;
    double num2;
    char op;

    printf("Enter a number: ");
    scanf("%lf", &num1);

    printf("Enter operator: ");
    scanf(" %c", &op);

    printf("Enter another number: ");
    scanf("%lf", &num2);

    if(op == '+'){
        printf("%f", num1 + num2);
    } else if(op == '-'){
        printf("%f", num1 - num2);
    } else if(op == '/'){
        printf("%f", num1 / num2);
    } else if(op == '*'){
        printf("%f", num1 * num2);
    } else{
        printf("Invalid operator");
    }




    if (!(3 = 2){
        printf("True");
    } else {
        printf("False");
    }

    This is the program that Lukas Macha build in 2020;
    do not edit below this line unless familiar with C/C++

    const int num = 5;
    double gpa;
    char grade;
    char school[] = "Jistebnice";
    char name[20];
    int age;
    double num1;
    double num2;

    char color[20];
    char pluralNoun[20];
    char celebrityF[20];
    char celebrityL[20];


    printf("Enter a color: ");
    scanf("%s", color);
    printf("Enter a plural noun: ");
    scanf("%s", pluralNoun);
    printf("Enter a celebrity name: ");
    scanf("%s%s", celebrityF,celebrityL);

    printf("Roses are %s\n", color);
    printf("%s are blue\n", pluralNoun);
    printf("I love %s %s\n", celebrityF,celebrityL);


    int luckyNumbers[10];
    printf("%d",luckyNumbers[1]);
    sum(4.4,5.2);

    printf("Answer : %f",cube(7.0));
    */
    return 0;
}
    /* This void funcion does not return anything
void sum(double a, double b)
{
    printf("The sum is: %lf ", a+b);
}


double cube(double num)
{
    return num*num*num;
}
    */
