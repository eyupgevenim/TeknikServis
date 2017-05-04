# TeknikServis
Tenik Servis ve Stok Takibi [C#, ef,DevExpress]

<h3> Veritabanı bağlantısının ayarı </h3>

- DAL'ın App.Config dosyasınının içindeki 

<code>
  <connectionStrings>
    <add name="teknikservisdbEntities" connectionString="metadata=res://*/teknikservisdbModel.csdl
    |res://*/teknikservisdbModel.ssdl
    |res://*/teknikservisdbModel.msl;provider=System.Data.SqlClient;provider 
    connection string=&quot;data source=SOFTR;initial catalog=teknikservisdb;integrated 
    security=True;MultipleActiveResultSets=True;App=EntityFramework&quot;" 
    providerName="System.Data.EntityClient" />
  </connectionStrings>
</code>

kısımında bulunan veritabanı bağlantısı kendi veritabaı connectionStrings göre düzeltmelisiniz.
örnek:
<code>
  connection string=&quot;data source=SOFTR;initial catalog=teknikservisdb;integrated 
</code>

bendeki server ismi "SOFTR" dır.
 
