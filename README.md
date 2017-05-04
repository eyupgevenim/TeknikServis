# TeknikServis
Tenik Servis ve Stok Takibi [C#, ef,DevExpress]

<h3> Projeyi çalıştıra bilmeniz için </h3>

- DevExpres ve SQL Server yüklü olmalıdır.


<h3> Veritabanı Ayarları </h3>

- Öncelikle veritabanı "teknikservisdb.bak" backup dosyasını SQL server'a yükleyin

<h4> Veritabanı bağlantısının ayarı </h4>

- DAL'ın App.Config dosyasınının içindeki 

<code>
  &lt;connectionStrings&gt;
    &lt;add name="teknikservisdbEntities" connectionString="metadata=res://*/teknikservisdbModel.csdl
    |res://*/teknikservisdbModel.ssdl
    |res://*/teknikservisdbModel.msl;provider=System.Data.SqlClient;provider 
    connection string=&quot;data source=SOFTR;initial catalog=teknikservisdb;integrated 
    security=True;MultipleActiveResultSets=True;App=EntityFramework&quot;" 
    providerName="System.Data.EntityClient" /&gt;
  &lt;/connectionStrings&gt;
</code>

<br />
kısımında bulunan veritabanı bağlantısı kendi veritabaı connectionStrings göre düzeltmelisiniz.

<br />
örnek:
<br />

<code>
  connection string=&quot;data source=SOFTR;initial catalog=teknikservisdb;integrated 
</code>

<br />
bendeki server ismi "SOFTR" dır.
