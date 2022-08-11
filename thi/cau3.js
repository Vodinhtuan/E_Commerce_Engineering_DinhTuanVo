class Sach {
    constructor(id,tensach,namxuatban,soquyen) {
        this.id=id;
        this.tenSach=tensach;
        this.namXuatban=namxuatban;
        this.soQuyen=soquyen;
        this.tinhTrang=soquyen>0;
    }

    setId(id)
    {
        this.id=id;
    }
    getId()
    {
        return this.id;
    }

    setTenSach(tensach)
    {
        this.tenSach=tensach;
    }
    getTenSach()
    {
        return this.tenSach;
    }

    setNamXuatban(namxuatban)
    {
        this.namXuatban=namxuatban;
    }
    getNamXuatban()
    {
        return this.namXuatban;
    }

    setSoQuyen(soquyen)
    {
        this.soQuyen=soquyen;
    }
    getSoQuyen()
    {
        return this.soQuyen;
    }

    setTinhTrang(tinhtrang)
    {
        this.tinhTrang=tinhtrang;
    }
    getTinhTrang()
    {
        return this.soQuyen>0;
    }
};
// ||
let listBooks=[];

function onView() {
    let str="<table border=\"1\" style=\"text-align: left; border-spacing: unset; width: 60%\">"
    str+="<tr><th>Mã số sách</th><th>Tên sách</th><th>Năm xuất bản</th><th>Số quyển</th><th>Tình trạng</th></tr>"
    for(let i=0; i<listBooks.length; i++)
    {
        str+="<tr>"
        str+="<td>"+listBooks[i].getId()+"</td>";
        str+="<td>"+listBooks[i].getTenSach()+"</td>";
        str+="<td>"+listBooks[i].getNamXuatban()+"</td>";
        str+="<td>"+listBooks[i].getSoQuyen()+"</td>";
        str+="<td>"+listBooks[i].getTinhTrang()+"</td>";
        str+="</tr>"
    }
    str+="</table>"
    document.getElementById("id_Table").innerHTML=str;
}

function Addbook() {
    let kiemtra=true;
    let id,tenSach,namXuatban,soQuyen;
    do {
        kiemtra=true;
        id=prompt("Nhập mã số sách:")
        tenSach=prompt("Tên sách: ");
        namXuatban=prompt("Năm xuất bản");
        soQuyen=parseInt(prompt("Số quyển: "));
        if(id.length!==5)
        {
            kiemtra=false;
        }
        else
        if(tenSach.length===0)
        {
            kiemtra=false;
        }
        else
        if(namXuatban.length>4)
        {
            kiemtra=false;
        }

    }while (kiemtra===false)
    if(kiemtra)
    {
        let sach=new Sach(id,tenSach,parseInt(namXuatban),soQuyen);
        listBooks.push(sach);
    }
    onView();
}


