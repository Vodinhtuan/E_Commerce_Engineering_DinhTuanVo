package QLBH;

import java.rmi.RemoteException;
import java.rmi.server.UnicastRemoteObject;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.text.NumberFormat;
import java.util.ArrayList;
import java.util.Locale;

import javax.swing.JOptionPane;

public class DAO extends UnicastRemoteObject implements Services{

	public static Locale localeVN = new Locale("vi","VN");
	public static NumberFormat currencyVN = NumberFormat.getCurrencyInstance(localeVN);
	public DAO() throws RemoteException{
		
	}
	public ArrayList<Bill> showBill() throws RemoteException, SQLException {
		Connection conn = DriverManager.getConnection("jdbc:sqlserver://localhost:1433;databasename=QLBH", "sa", "123456");
		Statement stmt = conn.createStatement();
		ResultSet rs=stmt.executeQuery("select * from HOADON");
		ArrayList<Bill> list = new ArrayList<>();
		while(rs.next()) {
			String mahd =rs.getString("MAHOADON");
			String makh =rs.getString("MAKH");
			String tentk =rs.getString("TENTK");
			String tongtien = currencyVN.format(rs.getInt("TONGTIEN"));
			String ngayban =rs.getString("NGAY");
			Bill bill = new Bill(mahd,makh,tentk,tongtien,ngayban);
			list.add(bill);
		}
		rs.close();
		stmt.close();
		conn.close();
		return list;
	}
	
	public ArrayList<BillInfor> ShowBillInfor(String mahd) throws SQLException{
		Connection conn = DriverManager.getConnection("jdbc:sqlserver://localhost:1433;databasename=QLBH", "sa", "123456");
		Statement stmt = conn.createStatement();
		ResultSet rs = stmt.executeQuery("select h.MAHANG , h.TENHANG,h.BAOHANH, cthd.SOLUONG,h.DONVITINH, cthd.DONGIA\r\n"
				+ "from HANGHOA h inner join CHITIETDONHANG cthd \r\n"
				+ "	on h.MAHANG = cthd.MAHANG inner join HOADON hd\r\n"
				+ "	on cthd.MAHOADON = hd.MAHOADON inner join KHACHHANG kh\r\n"
				+ "	on hd.MAKH = kh.MAKH\r\n"
				+ "	where cthd.MAHOADON like '"+mahd+"'");
		ArrayList<BillInfor> list2 = new ArrayList<>();
		while(rs.next()) {
			String mahang = rs.getString("MAHANG");
			String tenhang = rs.getString("TENHANG");
			String baohanh = rs.getString("BAOHANH");
			int soluong = rs.getInt("SOLUONG");
			String donvitinh = rs.getString("DONVITINH");
			String dongia = currencyVN.format(Long.parseLong(rs.getString("DONGIA")));
			BillInfor billinfor = new BillInfor(mahang,tenhang,soluong,donvitinh,dongia,baohanh);
			list2.add(billinfor);
		}
		rs.close();
		stmt.close();
		conn.close();
		return list2;
	}
	
	public ArrayList<Customer> showCustomerInfor() throws SQLException{
		Connection conn = DriverManager.getConnection("jdbc:sqlserver://localhost:1433;databasename=QLBH", "sa", "123456");
		Statement stmt = conn.createStatement();
		String sql ="select * from KHACHHANG";
		ResultSet rs = stmt.executeQuery(sql);
		ArrayList<Customer> list3 = new ArrayList<>();
		while(rs.next()) {
			String makh = rs.getString("MAKH");
			String tenkh = rs.getString("TENKH");
			String dienthoai = rs.getString("DIENTHOAI");
			String diachi = rs.getString("DIACHI");
			Customer customer = new Customer(makh,tenkh,dienthoai,diachi);
			list3.add(customer);
		}
		rs.close();
		stmt.close();
		conn.close();
		return list3;
	}
	public ArrayList<Customer> searchCustomerInfor(String text) throws SQLException{
		Connection conn = DriverManager.getConnection("jdbc:sqlserver://localhost:1433;databasename=QLBH", "sa", "123456");
		Statement stmt = conn.createStatement();
		String sql = "select * from KHACHHANG where TENKH like N'%"+text+"%'";
		ResultSet rs = stmt.executeQuery(sql);
		ArrayList<Customer> list3 = new ArrayList<>();
		while(rs.next()) {
			String makh = rs.getString("MAKH");
			String tenkh = rs.getString("TENKH");
			String dienthoai = rs.getString("DIENTHOAI");
			String diachi = rs.getString("DIACHI");
			Customer customer = new Customer(makh,tenkh,dienthoai,diachi);
			list3.add(customer);
		}
		rs.close();
		stmt.close();
		conn.close();
		return list3;
	}
	public void addCustomer(String tenkh,String dienthoai,String diachi) throws SQLException{
		Connection conn = DriverManager.getConnection("jdbc:sqlserver://localhost:1433;databasename=QLBH", "sa", "123456");
		Statement stmt = conn.createStatement();
		String sql = "insert into KHACHHANG(TENKH,DIENTHOAI,DIACHI) values(N'"+tenkh+"','"+dienthoai+"',N'"+diachi+"')";
		stmt.executeUpdate(sql);
		stmt.close();
		conn.close();
	}
	
	public ArrayList<Item> showItemInfor() throws SQLException,RemoteException{
		Connection conn = DriverManager.getConnection("jdbc:sqlserver://localhost:1433;databasename=QLBH", "sa", "123456");
		Statement stmt = conn.createStatement();
		String sql ="select * from HANGHOA";
		ResultSet rs = stmt.executeQuery(sql);
		ArrayList<Item> list4 = new ArrayList<>();
		while(rs.next()) {
			String mahang = rs.getString("MAHANG");
			String tenhang =rs.getString("TENHANG");
			int soluong = rs.getInt("SOLUONG");
			String donvitinh = rs.getString("DONVITINH");
			int dongia = rs.getInt("DONGIA");
			String baohanh = rs.getString("BAOHANH");
			Item item = new Item(mahang,tenhang,soluong,donvitinh,dongia,baohanh);
			list4.add(item);
		}
		rs.close();
		stmt.close();
		conn.close();
		return list4;
	}
	
	public ArrayList<Item> searchItemInfor(String text) throws SQLException,RemoteException{
		Connection conn = DriverManager.getConnection("jdbc:sqlserver://localhost:1433;databasename=QLBH", "sa", "123456");
		Statement stmt = conn.createStatement();
		String sql = "select * from HANGHOA where (TENHANG like N'%"+text+"%') or (MAHANG like N'%"+text+"%')";
		ResultSet rs = stmt.executeQuery(sql);
		ArrayList<Item> list4 = new ArrayList<>();
		while(rs.next()) {
			String mahang = rs.getString("MAHANG");
			String tenhang =rs.getString("TENHANG");
			int soluong = rs.getInt("SOLUONG");
			String donvitinh = rs.getString("DONVITINH");
			int dongia = rs.getInt("DONGIA");
			String baohanh = rs.getString("BAOHANH");
			Item item = new Item(mahang,tenhang,soluong,donvitinh,dongia,baohanh);
			list4.add(item);
		}
		rs.close();
		stmt.close();
		conn.close();
		return list4;
	}
	
	public void addItem(String tenhang,int soluong,String donvitinh,int dongia,String baohanh) throws SQLException,RemoteException {
		Connection conn = DriverManager.getConnection("jdbc:sqlserver://localhost:1433;databasename=QLBH", "sa", "123456");
		Statement stmt = conn.createStatement();
		String sql ="insert into HANGHOA(TENHANG,SOLUONG,DONVITINH,DONGIA,BAOHANH) values(N'"+tenhang+"',"+soluong+",N'"+donvitinh+"',"+dongia+",N'"+baohanh+"')";
		stmt.executeUpdate(sql);
		stmt.close();
		conn.close();
	}
	
	public int checkItem(String tenhang) throws SQLException,RemoteException {
		Connection conn = DriverManager.getConnection("jdbc:sqlserver://localhost:1433;databasename=QLBH", "sa", "123456");
		Statement stmt = conn.createStatement();
		ResultSet rs = stmt.executeQuery("select * from HANGHOA where TENHANG like N'"+tenhang+"'");
		while(rs.next()) {
			String tenhang2 = rs.getString("TENHANG");
			if(tenhang.equals(tenhang2)) {
				stmt.close();
				conn.close();
				return 1;				
			}
		}
		stmt.close();
		conn.close();
		return 0;
	}
	
	public void editItem(String mahang,String tenhang,int soluong,String donvitinh,int dongia,String baohanh) throws SQLException,RemoteException {
		Connection conn = DriverManager.getConnection("jdbc:sqlserver://localhost:1433;databasename=QLBH", "sa", "123456");
		Statement stmt = conn.createStatement();
		String sql = "update HANGHOA set TENHANG=N'"+tenhang+"', SOLUONG="+soluong+", DONVITINH=N'"+donvitinh+
				"',DONGIA="+dongia+",BAOHANH=N'"+baohanh+"' where MAHANG like '%"+mahang+"%'";
		stmt.executeUpdate(sql);
		stmt.close();
		conn.close();
	}
	
	public ArrayList<Staff> showStaffInfor() throws SQLException{
		Connection conn = DriverManager.getConnection("jdbc:sqlserver://localhost:1433;databasename=QLBH", "sa", "123456");
		Statement stmt = conn.createStatement();
		String sql ="select * from TAIKHOAN";
		ResultSet rs = stmt.executeQuery(sql);
		ArrayList<Staff> list5 = new ArrayList<>();
		while(rs.next()) {
			String tentk = rs.getString("TENTK");
			String hoten =rs.getString("HOTEN");
			String sdt = rs.getString("SDT");
			String diachi = rs.getString("DIACHI");
			Staff staff = new Staff(tentk,hoten,sdt,diachi);
			list5.add(staff);
		}
		rs.close();
		stmt.close();
		conn.close();
		return list5;
	}
	
	public ArrayList<Staff> searchStaffInfor(String text) throws SQLException{
		Connection conn = DriverManager.getConnection("jdbc:sqlserver://localhost:1433;databasename=QLBH", "sa", "123456");
		Statement stmt = conn.createStatement();
		String sql = "select * from TAIKHOAN where (TENTK like N'%"+text+"%') or (HOTEN like N'%"+text+"%')";
		ResultSet rs = stmt.executeQuery(sql);
		ArrayList<Staff> list5 = new ArrayList<>();
		while(rs.next()) {
			String tentk = rs.getString("TENTK");
			String hoten =rs.getString("HOTEN");
			String sdt = rs.getString("SDT");
			String diachi = rs.getString("DIACHI");
			Staff staff = new Staff(tentk,hoten,sdt,diachi);
			list5.add(staff);
		}
		rs.close();
		stmt.close();
		conn.close();
		return list5;
	}
	public String Login(String account,String password) throws SQLException{
		Connection conn = DriverManager.getConnection("jdbc:sqlserver://localhost:1433;databasename=QLBH", "sa", "123456");
		Statement stmt = conn.createStatement();
		boolean check=false;			
		String hoten = null;
		ResultSet rs =stmt.executeQuery("select * from TAIKHOAN");
		while(rs.next()) {
			String acc = rs.getString("TENTK");				
			if(account.equals(acc)==true) {
				hoten = rs.getString("HOTEN");
				check=true;
				break;
			}
		}
		ResultSet rs2=stmt.executeQuery("select * from TAIKHOAN where TenTK like '"+account+"'");
		if(check==true) {
			int a=0;
			while(rs2.next()) {
				String pw = rs2.getString("MATKHAU");
				
				if(password.equals(pw)==true) {					
					a=1;
					return hoten;
				}
			}
			if(a==0) {
				return null;
			}
		}else {
			return null;
		}
		return null;
	}
	@Override
	public String getCustomerName(String makh) throws SQLException, RemoteException {
		Connection conn = DriverManager.getConnection("jdbc:sqlserver://localhost:1433;databasename=QLBH", "sa", "123456");
		Statement stmt = conn.createStatement();
		ResultSet rs;
		rs = stmt.executeQuery("select * from KHACHHANG where MAKH like '"+makh+"'");
		while(rs.next()) {
		return rs.getString("TENKH");
				
		}
		rs.close();
		stmt.close();
		conn.close();
		return null;
	}
	public String getStaffName(String tentk) throws SQLException, RemoteException {
		Connection conn = DriverManager.getConnection("jdbc:sqlserver://localhost:1433;databasename=QLBH", "sa", "123456");
		Statement stmt = conn.createStatement();
		ResultSet rs;
		rs = stmt.executeQuery("select HOTEN from TAIKHOAN where TENTK like'"+tentk+"'");
		while(rs.next()) {
			return rs.getString("HOTEN");
		}
		rs.close();
		stmt.close();
		conn.close();	
		return null;
	}
	@Override
	public void addBill(String makh, String tentk, int tongtien, String ngay) throws SQLException, RemoteException {
		// TODO Auto-generated method stub
		Connection conn = DriverManager.getConnection("jdbc:sqlserver://localhost:1433;databasename=QLBH", "sa", "123456");
		Statement stmt = conn.createStatement();
		stmt.executeUpdate("insert into HOADON(MAKH,TENTK,TONGTIEN,NGAY) values('"+makh+"','"+tentk+"',"+tongtien+",'"+ngay+"')");
		stmt.close();
		conn.close();
	}
	@Override
	public void sellItem(int soluong, String mahang) throws SQLException, RemoteException {
		Connection conn = DriverManager.getConnection("jdbc:sqlserver://localhost:1433;databasename=QLBH", "sa", "123456");
		Statement stmt = conn.createStatement();
		stmt.executeUpdate("update HANGHOA set SOLUONG=SOLUONG-"+soluong+"where MAHANG='"+mahang+"'");
		stmt.close();
		conn.close();
	}
	@Override
	public String getBillCode(String ngay) throws SQLException, RemoteException {
		Connection conn = DriverManager.getConnection("jdbc:sqlserver://localhost:1433;databasename=QLBH", "sa", "123456");
		Statement stmt = conn.createStatement();
		ResultSet rs = stmt.executeQuery("select * from HOADON where NGAY like '"+ngay+"'");
		String mahd = null;
		while(rs.next()) {
			mahd = rs.getString("MAHOADON");
		}
		rs.close();
		stmt.close();
		conn.close();
		return mahd;
	}
	@Override
	public void addItemToBill(String mahd, String mahang, int soluong, int dongia)
			throws SQLException, RemoteException {
		// TODO Auto-generated method stub
		Connection conn = DriverManager.getConnection("jdbc:sqlserver://localhost:1433;databasename=QLBH", "sa", "123456");
		Statement stmt = conn.createStatement();
		stmt.executeUpdate("insert into CHITIETDONHANG values('"+mahd+"','"+mahang+"',"+soluong+","+dongia+")");
		stmt.close();
		conn.close();
	}
	@Override
	public ArrayList<Bill> getBillByCustomer(String makh)throws SQLException,RemoteException {		// TODO Auto-generated method stub
		Connection conn = DriverManager.getConnection("jdbc:sqlserver://localhost:1433;databasename=QLBH", "sa", "123456");
		Statement stmt = conn.createStatement();
		ResultSet rs = stmt.executeQuery("select * from HOADON where MAKH like '"+makh+"'");
		ArrayList<Bill> list = new ArrayList<>();
		while(rs.next()) {
			String mahd = rs.getString("MAHOADON");
			String tentk = rs.getString("TENTK");
			String tongtien = currencyVN.format(Long.parseLong(rs.getString("TONGTIEN")));
			String ngayban = rs.getString("NGAY");		
			Bill bill = new Bill(mahd, makh, tentk, tongtien, ngayban);
			list.add(bill);
		}
		rs.close();
		stmt.close();
		conn.close();
		return list;
	}
	@Override
	public ArrayList<Bill> getBillByStaff(String tentk) throws SQLException, RemoteException {
		// TODO Auto-generated method stub
		Connection conn = DriverManager.getConnection("jdbc:sqlserver://localhost:1433;databasename=QLBH", "sa", "123456");
		Statement stmt = conn.createStatement();
		ResultSet rs = stmt.executeQuery("select * from HOADON where TENTK like '%"+tentk+"%'");
		ArrayList<Bill> list = new ArrayList<>();
		while(rs.next()) {
			String mahd = rs.getString("MAHOADON");
			String makh = rs.getString("MAKH");
			String tongtien = currencyVN.format(Long.parseLong(rs.getString("TONGTIEN")));
			String ngayban = rs.getString("NGAY");
			Bill bill = new Bill(mahd, makh, tentk, tongtien, ngayban);
			list.add(bill);
		}
		rs.close();
		stmt.close();
		conn.close();
		return list;
	}
	@Override
	public void editCustomer(String makh,String hoten, String sdt, String diachi) throws SQLException, RemoteException {
		// TODO Auto-generated method stub
		Connection conn = DriverManager.getConnection("jdbc:sqlserver://localhost:1433;databasename=QLBH", "sa", "123456");
		Statement stmt = conn.createStatement();
		String sql = "update KHACHHANG set TENKH=N'"+hoten+"', DIENTHOAI=N'"+sdt+"', DIACHI=N'"+diachi+"' where MAKH like N'%"+makh+"%'";
		stmt.executeUpdate(sql);
		stmt.close();
		conn.close();
	}
	@Override
	public void addStaff(String tentk, String mk, String hoten, String sdt, String diachi)
			throws SQLException, RemoteException {
		Connection conn = DriverManager.getConnection("jdbc:sqlserver://localhost:1433;databasename=QLBH", "sa", "123456");
		Statement stmt = conn.createStatement();
		String sql = "insert into TAIKHOAN(TENTK,MATKHAU,HOTEN,SDT,DIACHI) values('"+tentk+"','"+mk+"',N'"+hoten+"','"+sdt+"',N'"+diachi+"');";
		stmt.executeUpdate(sql);
		stmt.close();
		conn.close();
	}
	@Override
	public void editStaff(String tentk, String mk, String hoten, String sdt, String diachi)
			throws SQLException, RemoteException {
		// TODO Auto-generated method stub
		Connection conn = DriverManager.getConnection("jdbc:sqlserver://localhost:1433;databasename=QLBH", "sa", "123456");
		Statement stmt = conn.createStatement();
		String sql = "update TAIKHOAN set MATKHAU='"+mk+"',HOTEN=N'"+hoten+"',SDT='"+sdt+"',DIACHI=N'"+diachi+"' where TENTK ='"+tentk+"'";
		stmt.executeUpdate(sql);
		stmt.close();
		conn.close();
	}
	@Override
	public String getPassword(String tentk) throws SQLException, RemoteException {
		Connection conn = DriverManager.getConnection("jdbc:sqlserver://localhost:1433;databasename=QLBH", "sa", "123456");
		Statement stmt = conn.createStatement();
		String sql = "select MATKHAU from TAIKHOAN where TENTK='"+tentk+"'";
		ResultSet rs = stmt.executeQuery(sql);
		while(rs.next()) {
			return rs.getString("MATKHAU");
		}
		return null;
	}
	@Override
	public boolean checkCustomerID(String id) throws SQLException, RemoteException {
		Connection conn = DriverManager.getConnection("jdbc:sqlserver://localhost:1433;databasename=QLBH", "sa", "123456");
		Statement stmt = conn.createStatement();
		String sql = "select MAKH from KHACHHANG where MAKH like '"+id+"'";
		ResultSet rs = stmt.executeQuery(sql);
		while(rs.next()) {
			if(id.equals(rs.getString("MAKH"))) {
				return true;
			}
		}
		return false;
	}
	@Override
	public ArrayList<Bill> searchBill(String text) throws RemoteException, SQLException {
		Connection conn = DriverManager.getConnection("jdbc:sqlserver://localhost:1433;databasename=QLBH", "sa", "123456");
		Statement stmt = conn.createStatement();
		String sql = "select * from HOADON where (MAHOADON like N'%"+text+"%') or (MAKH like N'%"+text+"%') or (TENTK like N'%"+text+"%');";
		ResultSet rs = stmt.executeQuery(sql);
		ArrayList<Bill> list = new ArrayList<>();
		while(rs.next()) {
			String mahd = rs.getString("MAHOADON");
			String makh = rs.getString("MAKH");
			String tentk = rs.getString("TENTK");
			String tongtien = rs.getString("TONGTIEN");
			String ngay = rs.getString("NGAY");
			Bill bill = new Bill(mahd, makh, tentk, tongtien, ngay);
			list.add(bill);
		}
		rs.close();
		stmt.close();
		conn.close();
		return list;
		
	}
	@Override
	public boolean checkAccount(String acc) throws SQLException, RemoteException {
		Connection conn = DriverManager.getConnection("jdbc:sqlserver://localhost:1433;databasename=QLBH", "sa", "123456");
		Statement stmt = conn.createStatement();
		String sql = "select * from TAIKHOAN where TENTK like '"+acc+"'";
		ResultSet rs = stmt.executeQuery(sql);
		while(rs.next()) {
			if(acc.equals(rs.getString("TENTK"))==true) {
				return true;
			}
		}
		return false;
	}	
	
}
