<?xml version="1.0" encoding="ISO-8859-1"?> 
	<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:output method="html" indent="yes"/>
	<xsl:template match="/">   
		<html>   
			<body>     
				<h2>Hotels in the Miami Area</h2> 
				<table border="1" bgcolor="#f4f3ef" cellpadding="4"> 
					<tr bgcolor="#d5ecfa" >         
						<th>Name</th>         
						<th>Rating</th> 
						<th>Average Price Per Night</th> 
					</tr>       
					<xsl:for-each select="ArrayOfHotelListItem/HotelListItem">  
						<xsl:sort select="Rating" order="descending"/>						
						<tr style="color:#3b4cba">
             <td><xsl:value-of select="Name" /></td>         
							<td>
                <xsl:choose>
                  <xsl:when test="Rating = 1.5">
                    <img src="..\..\Ratings\1.5.png"/>
                  </xsl:when>
                 </xsl:choose>
                <xsl:choose>
                  <xsl:when test="Rating = 2">
                    <img src="..\..\Ratings\2.png"/>
                  </xsl:when>
                </xsl:choose>
                <xsl:choose>
                  <xsl:when test="Rating = 3">
                    <img src="..\..\Ratings\3.png"/>
                  </xsl:when>
                </xsl:choose>
                <xsl:choose>
                  <xsl:when test="Rating = 4">
                    <img src="..\..\Ratings\4.png"/>
                  </xsl:when>
                </xsl:choose>
                <xsl:choose>
                  <xsl:when test="Rating = 5">
                    <img src="..\..\Ratings\5.png"/>
                  </xsl:when>
                </xsl:choose>
                <xsl:choose>
                  <xsl:when test="Rating = 2.5">
                    <img src="..\..\Ratings\2.5.png"/>
                  </xsl:when>
                </xsl:choose>
                <xsl:choose>
                  <xsl:when test="Rating = 3.5">
                    <img src="..\..\Ratings\3.5.png"/>
                  </xsl:when>
                </xsl:choose>
                <xsl:choose>
                  <xsl:when test="Rating = 4.5">
                    <img src="..\..\Ratings\4.5.png"/>
                  </xsl:when>
                </xsl:choose>
              </td>  
							<td>
								<table border="1" style="color:#3b4cba">
									<tr>
										<xsl:for-each select="Roomlist/Room"> 
											<td width="220">
												<xsl:value-of select="Type" /> = $<xsl:value-of select="DailyRate" />
											</td>  
										</xsl:for-each>  
									</tr>
								</table>
							</td>  
						</tr>       
					</xsl:for-each>  		
				</table>   
			</body>   
		</html> 
	</xsl:template> 
</xsl:stylesheet>