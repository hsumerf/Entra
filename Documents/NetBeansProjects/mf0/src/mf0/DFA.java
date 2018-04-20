/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package mf0;

/**
 *
 * @author H S Umer Farooq
 */
public class DFA {
    int initialState;
    int[] finalStates;
    char[] lang;
    int[][] TT;
    int states;

    public DFA(int initialStates, int[] finalStates, char[] lang, int[][] TT, int states) {
        this.initialState = initialStates;
        this.finalStates = finalStates;
        this.lang = lang;
        this.TT = TT;
        this.states = states;
    }
    
    public boolean validate(String input)
    {
        int currentState = initialState;
        
        for (int i = 0; i < input.length(); i++) {
            currentState = transition(currentState,input.charAt(i));
            if(currentState == -1)
                return false;
        }
        for (int i = 0; i < finalStates.length; i++) {
            if(finalStates[i] == currentState)
                return true;
        }
        return false;
    }
    
    private int transition(int state,char input)
    {
        int index =-1;
        for (int i = 0; i < lang.length; i++) {
            if(lang[i] == input)
            {
                index = i;
                break;
            }
        }
        if(index == -1)
            return index;
        
        return TT[state][index];
    }
}
