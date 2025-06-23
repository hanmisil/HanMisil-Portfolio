import socket
import time
from PyQt5.QtCore import QThread, pyqtSignal

class Client():    
    def __init__(self):
        super().__init__()
        
    def Send(self, msg):
        self.client_socket.send(bytes(msg.encode())) 

            
    def Connect(self, ip, port): 
        try:
            self.client_socket = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
            ADDR = (ip, int(port))
            self.client_socket.connect(ADDR)
            return True
        except :
            return False


    def Disconnect(self):
        self.client_socket.close();
        
            
class ClientThread(QThread):
    recvData = pyqtSignal(str)
    
    def __init__(self, client):
        super().__init__()
        self.client_socket = client
        
    def run(self):
        try:
            pass
            # while True:
            #     time.sleep(1)
            #     recv_data = self.client_socket.recv(1024).decode()
            #     self.recvData.emit(recv_data)
        except:
            pass

    def stop(self):
        self.quit()
