import sys
import serverSample
import clientSample
from PyQt5.QtCore import *
from PyQt5.QtWidgets import *

class GUI(QDialog):    
    def __init__(self, parent=None):        
        super().__init__(parent)        
        
       
        self.btn1 = QPushButton("Connect", self)               
        self.setGeometry(100, 50, 300, 300)


class Main(GUI):    
    server = serverSample.Server()
    
    
    def __init__(self, parent=None):
        super().__init__(parent) 
        
        ip = "192.168.10.148"
        port = 2006
        
        self.btn1.clicked.connect(lambda: self.clientConnect(ip, port))

        # self.clientConnect(ip, port)
        # serverConnect(ip, port) 
        self.show()
        
    def serverConnect(self, IP, Port):
        server = serverSample.Server()
        status = server.Connect(IP, Port)

        if status:
            server_Thread = serverSample.ServerSendThread(server.server_socket)
            server_Thread.start()
            # server_Thread.recvData.connect(self.RecvResult)
            
        else:
            print("Connect Failed")
            
            
            
    def clientConnect(self, IP, Port):
        client = clientSample.Client()
        status = client.Connect(IP, Port)

        if status:
            client_Thread = clientSample.ClientThread(client.client_socket)
            client_Thread.start()
            client_Thread.recvData.connect(self.RecvResult)
        else:
            print("connect failed")


    def RecvResult(self, recv):
        print("\r\nRecvResult : " + recv)
        
        
        
    

if __name__ == '__main__':
    
    app = QApplication(sys.argv)    
    form = Main()    
    
    app.exec_()


    
