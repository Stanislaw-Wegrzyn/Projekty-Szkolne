#include <cstdio>
#include <stdlib.h>
#include <time.h>

int main()
{
    srand (time(NULL));
    
    char tab[] = {'1','2','3','4','A','B','C','D'};
    char screen[3];
    
    printf("Podaj liczbę losowań:");
    
    int inp, los;
    
    bool TripleA;
    
    int pkt = 0;
    int runda = 0;
    
    scanf("%d", &inp);
    
    for (int i = 0; i < inp; i++){
        TripleA = true; runda = 0;
        printf("LOSOWANIE %d\n", i+1);
        printf("|=======|  ○\n");
        printf("|");
        for (int j = 0; j < 3; j++){
            screen[j] = tab[rand() % 8];
            printf(" %c", screen[j]);
            if (TripleA){
                if (screen[j] != 'A'){
                    TripleA = false;
                }
            }
        }
        if (!TripleA){
            if (screen[1] == 'A' && (screen[0] == 'A' || screen[2] == 'A')){
                pkt += 10; runda += 10;
            } else {
                if (screen[0] == screen[1] && screen[1] == screen[2]){
                   if ((screen[0] - 48) < 9) {
                       pkt += 20; runda += 20;
                   } else {
                       pkt += 30; runda += 30;
                   }
                }
            }
        } else {
            pkt += 50; runda += 50;
        }
        
        printf(" |  |\n");
        printf("|=======|__⅃\n");
        printf("PUNKTÓW W TEJ RUNDZIE: %d\n\n", runda);
    }
    
    printf("PUNKTÓW W CAŁEJ GRZE: %d", pkt);
    
    

    return 0;
}
