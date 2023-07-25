import pyodbc
import pandas as pd
import matplotlib.pyplot as plt


# 建立與資料庫的連接
conn = pyodbc.connect(
    'DRIVER={SQL Server};'
    'SERVER=DESKTOP-NDLH171;'
    'DATABASE=ChinAn;'
    'UID=sa;'
    'PWD=Rup40317@;'
)

# 執行 SQL 查詢並讀取結果到 DataFrame
sql_query = "SELECT year_month, amount FROM property"
data = pd.read_sql(sql_query, conn)

# 關閉資料庫連接
conn.close()

# 按照月份排序資料
data.sort_values(by='year_month', inplace=True)

# 創建趨勢表
plt.plot(data['year_month'], data['amount'])
plt.xlabel('year_month')
plt.ylabel('amount')
plt.title('每月金額趨勢')
plt.xticks(rotation=45)  # 若需要旋轉 x 軸標籤
plt.show()
