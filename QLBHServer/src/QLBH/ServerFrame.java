package QLBH;

import java.awt.BorderLayout;
import java.awt.Color;
import java.awt.Cursor;
import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;
import javax.swing.GroupLayout;
import javax.swing.GroupLayout.Alignment;
import javax.swing.JLabel;
import java.awt.Font;
import javax.swing.JTextField;
import javax.swing.LayoutStyle.ComponentPlacement;
import javax.swing.JButton;
import java.awt.event.ActionListener;
import java.io.IOException;
import java.rmi.Naming;
import java.rmi.RemoteException;
import java.rmi.registry.LocateRegistry;
import java.rmi.registry.Registry;
import java.awt.event.ActionEvent;
import javax.swing.SwingConstants;
import java.awt.Toolkit;
import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;

public class ServerFrame extends JFrame {

	private JPanel contentPane;
	private JTextField textIP;
	private JTextField textPort;
	public static String ip;
	public static int port;
	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					ServerFrame frame = new ServerFrame();
					frame.setVisible(true);
					frame.setLocationRelativeTo(null);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	/**
	 * Create the frame.
	 */
	public ServerFrame() {
		setIconImage(Toolkit.getDefaultToolkit().getImage(ServerFrame.class.getResource("/QLBH/icons8_server_32px.png")));
		setTitle("QLBH Server");
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 450, 300);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		
		JLabel lblNewLabel = new JLabel("IP:");
		lblNewLabel.setFont(new Font("Tahoma", Font.PLAIN, 16));
		
		JLabel lblNewLabel_1 = new JLabel("Port:");
		lblNewLabel_1.setFont(new Font("Tahoma", Font.PLAIN, 16));
		
		textIP = new JTextField();
		textIP.setColumns(10);
		
		JLabel lblServerCheck = new JLabel("");
		textPort = new JTextField();
		textPort.setColumns(10);
		
		JButton btnStart = new JButton("Bắt Đầu");
		btnStart.addMouseListener(new MouseAdapter() {
			@Override
			public void mouseEntered(MouseEvent e) {
				btnStart.setCursor(new Cursor(Cursor.HAND_CURSOR));
			}
		});
		btnStart.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				lblServerCheck.setText("Server đang khởi động!");
				port = Integer.parseInt(textPort.getText());
				ip = textIP.getText();
				try {
					Registry registry = LocateRegistry.createRegistry(port);
					String servicesName = "rmi://"+ip+":"+port+"/qlbhhh";
					DAO server = new DAO();			
					Runtime rt = Runtime.getRuntime();
					rt.exec("rmiregistry.exe");
					Naming.rebind(servicesName, server);	
					System.out.println("Service "+servicesName+" is running.");
					lblServerCheck.setForeground(Color.green);
					Thread th = new Thread() {
						public void run() {
							while(true) {
								lblServerCheck.setText("Server đang hoạt động");
								try {
									Thread.sleep(1000);
								} catch (InterruptedException e) {
									// TODO Auto-generated catch block
									e.printStackTrace();
								}
								lblServerCheck.setText("Server đang hoạt động.");
								try {
									Thread.sleep(1000);
								} catch (InterruptedException e) {
									// TODO Auto-generated catch block
									e.printStackTrace();
								}
								lblServerCheck.setText("Server đang hoạt động..");
								try {
									Thread.sleep(1000);
								} catch (InterruptedException e) {
									// TODO Auto-generated catch block
									e.printStackTrace();
								}
								lblServerCheck.setText("Server đang hoạt động...");
								try {
									Thread.sleep(1000);
								} catch (InterruptedException e) {
									// TODO Auto-generated catch block
									e.printStackTrace();
								}
							}
						}
					};
					th.start();
				} catch (RemoteException e1) {
					lblServerCheck.setText("Lỗi!");
					lblServerCheck.setForeground(Color.red);
					// TODO Auto-generated catch block
					e1.printStackTrace();
				} catch (IOException e2) {
					lblServerCheck.setText("Lỗi!");
					lblServerCheck.setForeground(Color.red);
					e2.printStackTrace();
				}
			}
		});
		
		JLabel lblNewLabel_2 = new JLabel("Cài Đặt Server");
		lblNewLabel_2.setFont(new Font("Tahoma", Font.PLAIN, 18));
		
		;
		lblServerCheck.setFont(new Font("Tahoma", Font.PLAIN, 13));
		lblServerCheck.setHorizontalAlignment(SwingConstants.CENTER);
		GroupLayout gl_contentPane = new GroupLayout(contentPane);
		gl_contentPane.setHorizontalGroup(
			gl_contentPane.createParallelGroup(Alignment.LEADING)
				.addGroup(gl_contentPane.createSequentialGroup()
					.addGroup(gl_contentPane.createParallelGroup(Alignment.LEADING)
						.addGroup(gl_contentPane.createSequentialGroup()
							.addGap(105)
							.addGroup(gl_contentPane.createParallelGroup(Alignment.LEADING, false)
								.addGroup(gl_contentPane.createSequentialGroup()
									.addComponent(lblNewLabel)
									.addGap(18)
									.addComponent(textIP, GroupLayout.PREFERRED_SIZE, 161, GroupLayout.PREFERRED_SIZE))
								.addGroup(gl_contentPane.createSequentialGroup()
									.addComponent(lblNewLabel_1)
									.addPreferredGap(ComponentPlacement.RELATED)
									.addComponent(textPort))))
						.addGroup(gl_contentPane.createSequentialGroup()
							.addGap(156)
							.addComponent(lblNewLabel_2, GroupLayout.PREFERRED_SIZE, 122, GroupLayout.PREFERRED_SIZE)))
					.addContainerGap(119, Short.MAX_VALUE))
				.addGroup(Alignment.TRAILING, gl_contentPane.createSequentialGroup()
					.addContainerGap(143, Short.MAX_VALUE)
					.addComponent(lblServerCheck, GroupLayout.PREFERRED_SIZE, 149, GroupLayout.PREFERRED_SIZE)
					.addGap(132))
				.addGroup(Alignment.TRAILING, gl_contentPane.createSequentialGroup()
					.addContainerGap(182, Short.MAX_VALUE)
					.addComponent(btnStart)
					.addGap(171))
		);
		gl_contentPane.setVerticalGroup(
			gl_contentPane.createParallelGroup(Alignment.LEADING)
				.addGroup(gl_contentPane.createSequentialGroup()
					.addContainerGap()
					.addComponent(lblNewLabel_2, GroupLayout.PREFERRED_SIZE, 25, GroupLayout.PREFERRED_SIZE)
					.addGap(18)
					.addGroup(gl_contentPane.createParallelGroup(Alignment.BASELINE)
						.addComponent(lblNewLabel)
						.addComponent(textIP, GroupLayout.PREFERRED_SIZE, GroupLayout.DEFAULT_SIZE, GroupLayout.PREFERRED_SIZE))
					.addGap(42)
					.addGroup(gl_contentPane.createParallelGroup(Alignment.BASELINE)
						.addComponent(lblNewLabel_1)
						.addComponent(textPort, GroupLayout.PREFERRED_SIZE, GroupLayout.DEFAULT_SIZE, GroupLayout.PREFERRED_SIZE))
					.addPreferredGap(ComponentPlacement.RELATED, 20, Short.MAX_VALUE)
					.addComponent(lblServerCheck)
					.addGap(18)
					.addComponent(btnStart)
					.addGap(36))
		);
		contentPane.setLayout(gl_contentPane);
	}
}
