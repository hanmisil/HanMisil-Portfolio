import socket
import time
from PyQt5.QtCore import QThread, pyqtSignal, pyqtSlot


class Server():
    def __init__(self):
        super().__init__()
        self.server_socket: socket
        
    # ConnectionRefusedError
    def Connect(self, ip, port):
        try:
            ADDR = (ip, int(port))
            self.server_socket = socket.socket(socket.AF_INET, socket.SOCK_STREAM) 
            self.server_socket.bind(ADDR)
            self.server_socket.listen()
            return True
        except:
            return False
            

    def Disconnect(self):
        self.server_socket.close()


class ServerRecvThread(QThread):
    connect = pyqtSignal(str)
    recvData = pyqtSignal(str)
    
    def __init__(self, server):
        super().__init__()
        self.server_socket = server
        self.recvThread: RecvThread

    def run(self):
        try:
            while True:
                # 클라이언트 연결 대기
                self.client_socket, client_address = self.server_socket.accept()
                # self.connect.emit(client_address[0])
                
                recvThread = RecvThread(self.client_socket)
                recvThread.start()
                recvThread.recvData.connect(self.GetRecv) 
        except:
            pass       
    
    @pyqtSlot(str)
    def GetRecv(self, recv):
        self.recvData.emit(recv)
                    
    
    def stop(self):
        self.client_socket.close();
        self.quit()
        

        
class RecvThread(QThread):
    recvData = pyqtSignal(str)
    
    def __init__(self, client):
        super().__init__()
        self.client_socket = client
        

    def run(self):
        try:
            while True:
                time.sleep(1)
                recv_data = self.client_socket.recv(1024).decode()  # 클라이언트가 보낸 메시지 반환
                if recv_data != "":
                    self.recvData.emit(recv_data)
        except:
            pass

    def stop(self):
        self.quit()
    


class ServerSendThread(QThread):
    connect = pyqtSignal(str)
    
    def __init__(self, server):
        super().__init__()
        self.server_socket = server
        self.client_socket: socket
        self.sendThread: SendThread
        self.ip = None

    def run(self):
        # try:
            while True:
                self.client_socket, client_address = self.server_socket.accept()
                if self.ip == None or self.ip != client_address[0]:
                    self.connect.emit(client_address[0])
                    self.ip = client_address[0]
                                    
                self.sendThread = SendThread(self.client_socket)
                self.sendThread.start()
        
        # except Exception as e:
        #     print("error: " + str(e))
        #     pass

    def send(self, msg):
        self.client_socket.send(msg.encode())  # 클라이언트에게 응답
        
        
    def stop(self):
        self.quit()
        self.wait(5000)
        
        
class SendThread(QThread):
    recvData = pyqtSignal(str)
    
    def __init__(self, client):
        super().__init__()
        self.client_socket = client


    def send(self, msg):
        self.client_socket.send(msg.encode())
        

    def stop(self):
        self.quit()
