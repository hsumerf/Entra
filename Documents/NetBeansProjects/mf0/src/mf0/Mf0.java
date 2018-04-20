/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package mf0;

import java.util.Scanner;

/**
 *
 * @author H S Umer Farooq
 */
public class Mf0 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        Scanner sc = new Scanner(System.in);
        int states = 4;
        int initial_state = 0;
        int final_states[] = { 0 };
        int[][] transitionTable = { {1,3},
                                    {0,2},
                                    {3,1},
                                    {2,0} };
        char[] lang = {'a','b'};
        
        DFA dfa = new DFA(initial_state,final_states,lang,transitionTable,states);
        String s = sc.nextLine();
        System.out.println(dfa.validate(s));
                
    }
    
}
