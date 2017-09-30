Attack.cs: AttackColl.cs
	mcs Attack.cs

AttackColl.cs:
	mcs AttackColl.cs

clean:
	rm Attack.exe
	rm AttackColl.exe