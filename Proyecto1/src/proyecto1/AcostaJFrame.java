package proyecto1;

import java.awt.FlowLayout;
import java.awt.GridLayout;
import java.awt.LayoutManager;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import javax.swing.BoxLayout;
import javax.swing.GroupLayout;
import javax.swing.JButton;
import javax.swing.JComboBox;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JPanel;
import javax.swing.JTextField;
import javax.swing.event.AncestorListener;

public class AcostaJFrame extends javax.swing.JFrame {

    public AcostaJFrame() {
        initComponents();
    }

    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        newFrame = new javax.swing.JButton();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

        newFrame.setText("Crea Nuevo Framne");
        newFrame.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                newFrameActionPerformed(evt);
            }
        });

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addGap(123, 123, 123)
                .addComponent(newFrame)
                .addContainerGap(148, Short.MAX_VALUE))
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addGap(19, 19, 19)
                .addComponent(newFrame)
                .addContainerGap(258, Short.MAX_VALUE))
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void newFrameActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_newFrameActionPerformed
        // TODO add your handling code here:

        JButton boton1 = new JButton("Botón 1");
        JButton boton2 = new JButton("Botón 2");
        JButton botonAux = new JButton("Botón auxiliar");
        JButton botonAux1 = new JButton("Boton auxiliar 2");
        JTextField jt2 = new JTextField("Probando panel 2");
        JFrame frame = new JFrame("Frame nuevo");
        JPanel jp = new JPanel();
        JPanel jp2 = new JPanel();
        Object[] grupo = {
            "Barcelona",
            "Tottenham",
            "PSV",
            "Inter de Milan"
                
        };
        JComboBox combo = new JComboBox(grupo);
        //frame.add(boton);
        // frame.setBounds(300, 300, 300, 300);

        frame.setVisible(true);
        frame.setSize(400, 400);
        jp.add(boton1);
        jp.add(boton2);
        jp2.add(botonAux);
        jp.add(new JTextField("Probando panel"));
        jp.add(new JLabel("Nombre:"));
        jp.add(new JButton("Boton:"));
        jp2.add(botonAux1);
        jp2.add(jt2);
        //combo.addItem("Hola");
        jp2.add(combo);

        frame.add(jp);
        frame.add(jp2);
        frame.setLayout(new GridLayout());
        /* frame.add(new JPanel().add(new JButton("Nuevo panel botón")));*/
        
        //agregar boton desde el segundo frame

        botonAux.addActionListener(new ActionListener(){
            @Override
            public void actionPerformed(ActionEvent e) {
               
                
                jp.add(new JButton("Botón generado"));
                jp.validate();
                
            }
            
        });
        
        combo.addActionListener(new ActionListener(){
            @Override
            public void actionPerformed(ActionEvent ae) {
           
                jp.add(new JTextField(combo.getSelectedItem().toString()));
                jp.validate();
            }
        
        });
        

    }//GEN-LAST:event_newFrameActionPerformed

    public static void main(String args[]) {

        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new AcostaJFrame().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton newFrame;
    // End of variables declaration//GEN-END:variables
}
