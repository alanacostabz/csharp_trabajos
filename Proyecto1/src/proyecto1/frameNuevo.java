/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package proyecto1;

import java.awt.GridLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import javax.swing.JButton;
import javax.swing.JComboBox;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JPanel;
import javax.swing.JTextField;

/**
 *
 * @author bryan
 */
public class frameNuevo {

    public static void main(String[] args) {

        frame f = new frame();
        f.setVisible(true);
        f.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);

    }

}

class frame extends JFrame {

    public frame() {

        setTitle("Primer Frame");
        setSize(400, 400);
        botonInicial panelUno = new botonInicial();
        add(panelUno);

    }

}

class botonInicial extends JPanel implements ActionListener {

    JButton botonInicial = new JButton("Abrir segundo frame");

    public botonInicial() {
        add(botonInicial);
        botonInicial.addActionListener(this);
    }

    @Override
    public void actionPerformed(ActionEvent e) {
        newFrame frameNuevo = new newFrame();
        frameNuevo.setVisible(true);
        frameNuevo.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);

    }

}

class newFrame extends JFrame {

    public newFrame() {

        setTitle("Segundo Frame");
        setSize(400, 400);
        primerPanel panelUno = new primerPanel();
        segundoPanel panelDos = new segundoPanel();
        add(panelUno);
        add(panelDos);
        setLayout(new GridLayout());

    }

}

class primerPanel extends JPanel {

    JButton boton1 = new JButton("Botón 1");
    JButton boton2 = new JButton("Botón 2");
    JTextField textoUno = new JTextField("Este campo es del panel 1");
    JLabel etiquetaUno = new JLabel("Panel 1");

    public primerPanel() {
        add(boton1);
        add(boton2);
        add(textoUno);
        add(etiquetaUno);
    }

}

class segundoPanel extends JPanel implements ActionListener {

    JButton boton3 = new JButton("Botón 3");
    JButton boton4 = new JButton("Botón 4");
    JTextField textoDos = new JTextField("Este campo es del panel 2");
    Object[] grupo = {
            "Barcelona",
            "Tottenham",
            "PSV",
            "Inter de Milan"
                
        };
    JComboBox combo = new JComboBox(grupo);

    public segundoPanel() {
        add(boton3);
        add(boton4);
        add(textoDos);
        add(combo);
        boton3.addActionListener(this);
        

    }
    
    public void actionPerformed(ActionEvent e) {
        JButton botonNuevo = new JButton("Boton generado");
        primerPanel panelUno = new primerPanel();
        panelUno.add(botonNuevo);
        panelUno.setVisible(true);
        

    }

}
