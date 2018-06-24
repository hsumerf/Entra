/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package dfa_or2;

import java.util.ArrayList;

/**
 *
 * @author H S Umer Farooq
 */
public class DFA {
    int no_of_states;
    int initialstate;
    int[] final_states;
    char[] allowedChar;
    int[][] ttable;

    public DFA(int no_of_states, int initialstate, int[] final_states, char[] allowedChar, int[][] ttable) 
    {
        this.no_of_states = no_of_states;
        this.initialstate = initialstate;
        this.final_states = final_states;
        this.allowedChar = allowedChar;
        this.ttable = ttable;
    }
    public DFA()
    {}
    public boolean validate(String input)
    {
        
                int CS = 0;
                for (int i = 0; i < input.length(); i++) 
                {
                     CS = ttable(input.charAt(i),CS);
                     
               
                }
               for (int i = 0; i < final_states.length; i++) 
               {
                   if(CS==final_states[i])
                       return true;
                   
                }
               return false;
 
                
                
                
    }
    
    public int ttable(char c,int state)
    {
                if(c=='a')
                    return ttable[state][0];
                else
                    return ttable[state][1];
    }
    
    
    
}
