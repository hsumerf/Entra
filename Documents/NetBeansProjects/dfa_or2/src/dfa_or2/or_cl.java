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
public class or_cl {
    DFA f1,f2,f3;
    ArrayList<Node> states = new ArrayList<Node>();
    Node z;
    int[][] final_ttable;

    public or_cl(DFA f1, DFA f2) {
        this.f1 = f1;
        this.f2 = f2;
        this.f3 = new DFA();
        this.z = new Node(0,0);
        this.final_ttable = new int[f1.no_of_states*f2.no_of_states][2];
        
    }
    
    public void merge()
    {
        int temp=0;
        z.index = 0;
        states.add(z);
        for (int i = 0; i < states.size(); i++) 
        {
            for (int j = 0; j < f1.allowedChar.length; j++) 
            {
                z = new Node();
                
                z.x = f1.ttable(f1.allowedChar[j], states.get(i).x);
                z.y = f2.ttable(f1.allowedChar[j], states.get(i).y);
                for (int k = 0; k < states.size(); k++) 
                            {
                            if(states.get(k).x!=z.x || states.get(k).y!=z.y)
                             temp++;
                            }
                       if(temp==states.size())
                       {
                        z.index=states.size();   
                        states.add(z);
                       }
                temp=0;
                for (int k = 0; k < states.size(); k++) {
                    if(z.x == states.get(k).x && z.y == states.get(k).y)
                    {
                        final_ttable[i][j] = states.get(k).index;
                    }
                }
                
            }
            
        }
    }
    
    public void make_final_states()
    {
        f3.final_states = new int[10];
        int[] final_states3 = new int[10];
        for (int i = 0; i < states.size(); i++) 
        {
            for (int j = 0; j < f1.final_states.length; j++) {
                
            
                if(states.get(i).x==f1.final_states[j] || states.get(i).y==f2.final_states[j])
                {
                 final_states3[i] = states.get(i).index;
                    System.out.println(final_states3[i]);
                }
            }
                
        }
        f3.final_states = final_states3;
    }
    
    public void validation(String input)
    {
        f3.ttable=final_ttable;
        f3.allowedChar=f1.allowedChar;
        f3.no_of_states=f1.no_of_states*f2.no_of_states;
        System.out.println(f3.validate(input));
    }
}
