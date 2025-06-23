import configparser
import os

def IniWrite(section, key, Value, path):
    WritePrivateProfileString(section, key, Value, path)
    

def IniRead(section, key, default, filePath):
    val = GetPrivateProfileString(section, key, default, filePath)
    return val


# Set value
def WritePrivateProfileString(section, key, val, filePath):
    configFile = configparser.ConfigParser()
    configFile.read(filePath)

    try:
        configFile.set(section, key, val)
    except configparser.NoSectionError:
        configFile.add_section(section)
        configFile.set(section, key, val)
    except TypeError:
        configFile.set(section, key, str(val))
    except:
        pass
    finally:
        with open(filePath, 'w') as file:
            configFile.write(file)

# Get value
def GetPrivateProfileString(section, key, default, filePath):

    val = None        
    configFile = configparser.ConfigParser()
    configFile.read(filePath)

    try:
        val = configFile[section][key]
    except:
        IniWrite(section, key, default, filePath)
        val = default
    
    return val



PATH = r"C:\Users\user\Desktop";
INIFILE = os.path.join(PATH, "INIFile_python.ini");

# .ini 파일 쓰기
IniWrite("Section1", "key1-1", "value1-1", INIFILE);
IniWrite("Section1", "key1-2", "value1-2", INIFILE);
IniWrite("Section2", "key2-1", "value2-1", INIFILE);
IniWrite("Section2", "key2-2", "value2-2", INIFILE);

#  .ini 파일 읽기
v1 = IniRead("Section1", "key1-1", "value", INIFILE);
v2 = IniRead("Section2", "key2-1", "value", INIFILE);

print("Section key1-1 : " + v1);
print("Section key2-1 : " + v2);

#  만약에 해당하는 key가 없을 경우 예시
v4 = IniRead("Section", "key4", "value", INIFILE);
print("Section key4 : " + v4);
