# Unity Developer Test - README

## 1️⃣ Project Setup & Installation

### **🔹 Yêu cầu hệ thống**
- Unity **2022.3.57f1 LTS** (hoặc phiên bản tương thích)

### **🔹 Cách chạy project**
#### **Bước 1: Clone Repository**

#### **Bước 2: Mở project trong Unity**
- Chạy **Unity Hub**, mở thư mục chứa project.
- Chờ Unity tải các dependencies.

#### **Bước 3: Cấu hình Photon Fusion (nếu gặp lỗi thiếu fusion app Id)**
- Vào **Tool > Fusion > Fusion Hub > nhập Fusion ID** (liên hệ mình để lấy fusion app Id)

#### **Bước 4: Chạy game**
- Bấm **Play** trong Unity Editor.
- Build game (`File > Build Settings`) để test với nhiều client hoặc mở file build có sẵn trong thư mục (`Build`).
- Bấm **Start Shared Client** để kết nối

---

## 2️⃣ Features Implemented

### **🕹️ Character Movement**
✅ Hỗ trợ **WASD** để di chuyển.  
✅ **Chuột** để xoay camera.  
✅ **Shift** để chạy nhanh.  
✅ **Space** để nhảy.  
✅ Dùng **Rigidbody + Interpolation** giúp chuyển động mượt hơn.

### **🌍 Multiplayer (Photon Fusion 2)**
✅ Hỗ trợ **nhiều người chơi** trong cùng 1 session.  
✅ **Có thể random ngẫu nhiên màu của người chơi** (Character Customization).  
✅ Hiển thị **tên người chơi trên nhân vật**.  
✅ Đồng bộ **di chuyển & xoay nhân vật** trên tất cả client.  

### **🎮 UI & Game Flow**
✅ **Tên người chơi hiển thị trên đầu nhân vật**.  
✅ **UI đơn giản** để bắt đầu game.  
✅ Game được tổ chức gọn gàng với **Prefabs & Scene Organization**.

---

## 3️⃣ Tools & Libraries Used

| Công cụ / Thư viện  | Mô tả |
|--------------------|----------------------------------|
| **Unity 2022.3.57f1 LTS**  | Engine game chính |
| **Photon Fusion 2**  | Hỗ trợ Multiplayer & Networking |
| **TextMeshPro**  | UI hiển thị tên nhân vật |
| **Add-on Fusion Network Physics** | Xử lý đồng bộ vật lý trên mạng |

---

### 🚀 Chúc bạn test game vui vẻ! Nếu có lỗi, hãy liên hệ với tôi. 😃

