/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package dfa_or2;

/**
 *
 * @author H S Umer Farooq
 */
public class Dfa_or2 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        //int[][] ttable1 = new int[2][3];
        int[][] ttable1 = {{1,0},
                           {1,0}};
        int[] final_st = {1};
        char[] allowed_char = {'a','b'};
        
//        public DFA(int no_of_states, int initialstate, int[] final_states, char[] allowedChar, int[][] ttable) 

        DFA f1 = new DFA(2,0,final_st,allowed_char,ttable1);
        System.out.println(f1.validate("aa"));
    }
    
}
