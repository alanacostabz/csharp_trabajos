/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package proyecto1;

import java.awt.Component;
import java.awt.Container;
import javax.swing.JFrame;
import javax.swing.JOptionPane;
import javax.swing.JPanel;
import javax.swing.JTextField;

/**
 *
 * @author dii
 */
public class PrimerVentana extends javax.swing.JFrame {

    /**
     * Creates new form PrimerVentana
     */
    public PrimerVentana() {
        initComponents();
    }

    /**
     * This method is called from within the constructor to initialize the form.
     * WARNING: Do NOT modify this code. The content of this method is always
     * regenerated by the Form Editor.
     */
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        buttonGroup1 = new javax.swing.ButtonGroup();
        btnName = new javax.swing.JButton();
        txtName = new javax.swing.JTextField();
        lblName = new javax.swing.JLabel();
        comboName = new javax.swing.JComboBox<>();
        cbRed = new javax.swing.JCheckBox();
        cbBlue = new javax.swing.JCheckBox();
        cbYellow = new javax.swing.JCheckBox();
        btnHab = new javax.swing.JButton();
        jPanel1 = new javax.swing.JPanel();
        jButton1 = new javax.swing.JButton();
        tf2 = new javax.swing.JTextField();
        cb2 = new javax.swing.JComboBox<>();
        jButton2 = new javax.swing.JButton();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

        btnName.setText("Despliega Nombre");
        btnName.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnNameActionPerformed(evt);
            }
        });

        lblName.setText("Proporciona tu nombre:");

        comboName.setModel(new javax.swing.DefaultComboBoxModel<>(new String[] { "messi", "ronaldinho", "cr7", "zidane" }));
        comboName.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                comboNameActionPerformed(evt);
            }
        });

        buttonGroup1.add(cbRed);
        cbRed.setText("Rojo");
        cbRed.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                cbRedActionPerformed(evt);
            }
        });

        buttonGroup1.add(cbBlue);
        cbBlue.setText("Azul");
        cbBlue.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                cbBlueActionPerformed(evt);
            }
        });

        buttonGroup1.add(cbYellow);
        cbYellow.setText("Amarillo");
        cbYellow.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                cbYellowActionPerformed(evt);
            }
        });

        btnHab.setText("Deshabilitar");
        btnHab.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                btnHabMouseClicked(evt);
            }
        });
        btnHab.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnHabActionPerformed(evt);
            }
        });

        jPanel1.setBackground(new java.awt.Color(102, 153, 255));

        jButton1.setText("jButton1");
        jButton1.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton1ActionPerformed(evt);
            }
        });

        tf2.setText("jTextField1");

        cb2.setModel(new javax.swing.DefaultComboBoxModel<>(new String[] { "Item 1", "Item 2", "Item 3", "Item 4" }));

        javax.swing.GroupLayout jPanel1Layout = new javax.swing.GroupLayout(jPanel1);
        jPanel1.setLayout(jPanel1Layout);
        jPanel1Layout.setHorizontalGroup(
            jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel1Layout.createSequentialGroup()
                .addContainerGap(125, Short.MAX_VALUE)
                .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanel1Layout.createSequentialGroup()
                        .addComponent(cb2, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addGap(36, 36, 36)
                        .addComponent(jButton1)
                        .addGap(102, 102, 102))
                    .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanel1Layout.createSequentialGroup()
                        .addComponent(tf2, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addGap(142, 142, 142))))
        );
        jPanel1Layout.setVerticalGroup(
            jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel1Layout.createSequentialGroup()
                .addGap(30, 30, 30)
                .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jButton1)
                    .addComponent(cb2, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(tf2, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addContainerGap(21, Short.MAX_VALUE))
        );

        jButton2.setText("jButton2");
        jButton2.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton2ActionPerformed(evt);
            }
        });

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addGap(37, 37, 37)
                .addComponent(lblName)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(txtName, javax.swing.GroupLayout.PREFERRED_SIZE, 198, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addComponent(btnName)
                .addContainerGap(12, Short.MAX_VALUE))
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                            .addComponent(comboName, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                .addComponent(cbBlue)
                                .addComponent(cbYellow)
                                .addComponent(cbRed))
                            .addComponent(btnHab))
                        .addGap(35, 35, 35)
                        .addComponent(jButton2)
                        .addGap(103, 103, 103))
                    .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                        .addComponent(jPanel1, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addGap(51, 51, 51))))
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addGap(71, 71, 71)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(txtName, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(btnName)
                    .addComponent(lblName))
                .addGap(18, 18, 18)
                .addComponent(comboName, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(18, 18, 18)
                .addComponent(cbRed)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addComponent(cbBlue)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(cbYellow)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(btnHab)
                    .addComponent(jButton2))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(jPanel1, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addContainerGap(18, Short.MAX_VALUE))
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void btnNameActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnNameActionPerformed

        JOptionPane.showMessageDialog(this, "Hola " + txtName.getText());
    }//GEN-LAST:event_btnNameActionPerformed

    private void comboNameActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_comboNameActionPerformed
        // TODO add your handling code here:
        JOptionPane.showMessageDialog(this, "Hola " + comboName.getSelectedItem());
    }//GEN-LAST:event_comboNameActionPerformed

    private void cbRedActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_cbRedActionPerformed
        // TODO add your handling code here:
        mostrarColor(cbRed.getText());
    }//GEN-LAST:event_cbRedActionPerformed

    private void cbBlueActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_cbBlueActionPerformed
        // TODO add your handling code here:
        mostrarColor(cbBlue.getText());
    }//GEN-LAST:event_cbBlueActionPerformed

    private void cbYellowActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_cbYellowActionPerformed
        // TODO add your handling code here:
        mostrarColor(cbYellow.getText());
    }//GEN-LAST:event_cbYellowActionPerformed

    private void btnHabActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnHabActionPerformed
        // TODO add your handling code here:

        //habilitar deshabilitar
    }//GEN-LAST:event_btnHabActionPerformed

    private void btnHabMouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_btnHabMouseClicked
        // TODO add your handling code here:
        estadoComponente(comboName, !comboName.isEnabled());
        estadoComponente(txtName, !txtName.isEnabled());
        estadoComponente(btnName, !btnName.isEnabled());
        estadoComponente(cbRed, !cbRed.isEnabled());
        estadoComponente(cbBlue, !cbBlue.isEnabled());
        estadoComponente(cbYellow, !cbYellow.isEnabled());
        estadoComponente(lblName, !lblName.isEnabled());
     


    }//GEN-LAST:event_btnHabMouseClicked

    private void jButton1ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton1ActionPerformed
        // TODO add your handling code here:
       
       
        
    }//GEN-LAST:event_jButton1ActionPerformed

    private void jButton2ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton2ActionPerformed
        // TODO add your handling code here:
         estadoComponente(jPanel1, !jPanel1.isEnabled());
    }//GEN-LAST:event_jButton2ActionPerformed
    public void mostrarColor(String color) {
        JOptionPane.showMessageDialog(this, "Color seleccionado : " + color);
    }

    public void estadoComponente(Container c, boolean estado) {

        Component[] componentes = c.getComponents();
        c.setEnabled(estado);
        for (int i = 0; i < componentes.length; i++) {
            componentes[i].setEnabled(estado);

            if (estado == false) {

                btnHab.setText("Habilitar");

            } else {

                btnHab.setText("Deshabilitar");

            }

            if (componentes[i] instanceof Container) {
                estadoComponente((Container) componentes[i], estado);
            }

        }
    }

    /**
     * @param args the command line arguments
     */
    public static void main(String args[]) {
        /* Set the Nimbus look and feel */
        //<editor-fold defaultstate="collapsed" desc=" Look and feel setting code (optional) ">
        /* If Nimbus (introduced in Java SE 6) is not available, stay with the default look and feel.
         * For details see http://download.oracle.com/javase/tutorial/uiswing/lookandfeel/plaf.html 
         */
        try {
            for (javax.swing.UIManager.LookAndFeelInfo info : javax.swing.UIManager.getInstalledLookAndFeels()) {
                if ("Nimbus".equals(info.getName())) {
                    javax.swing.UIManager.setLookAndFeel(info.getClassName());
                    break;
                }
            }
        } catch (ClassNotFoundException ex) {
            java.util.logging.Logger.getLogger(PrimerVentana.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(PrimerVentana.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(PrimerVentana.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(PrimerVentana.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        /* Create and display the form */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new PrimerVentana().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton btnHab;
    private javax.swing.JButton btnName;
    private javax.swing.ButtonGroup buttonGroup1;
    private javax.swing.JComboBox<String> cb2;
    private javax.swing.JCheckBox cbBlue;
    private javax.swing.JCheckBox cbRed;
    private javax.swing.JCheckBox cbYellow;
    private javax.swing.JComboBox<String> comboName;
    private javax.swing.JButton jButton1;
    private javax.swing.JButton jButton2;
    private javax.swing.JPanel jPanel1;
    private javax.swing.JLabel lblName;
    private javax.swing.JTextField tf2;
    private javax.swing.JTextField txtName;
    // End of variables declaration//GEN-END:variables
}
