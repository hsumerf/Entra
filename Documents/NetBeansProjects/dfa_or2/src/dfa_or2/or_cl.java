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
        states.add(z);
        for (int i = 0; i < states.size(); i++) 
        {
            for (int j = 0; j < f1.allowedChar.length; j++) 
            {
                z = new Node();
                z.x = f1.ttable(f1.allowedChar[j], states.get(i).x);
                z.y = f2.ttable(f1.allowedChar[j], states.get(i).y);
                for (int k = 0; k < states.size(); k++) {
                    if(z.equals(states.get(k)))
                        break;
                    else if(!z.equals(states.get(k)))
                       states.add(z);
                        
                }
                
            }
        }
    }
    
}
